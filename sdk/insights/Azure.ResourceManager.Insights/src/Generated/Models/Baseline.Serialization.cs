// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class Baseline
    {
        internal static Baseline DeserializeBaseline(JsonElement element)
        {
            Sensitivity sensitivity = default;
            IReadOnlyList<double> lowThresholds = default;
            IReadOnlyList<double> highThresholds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sensitivity"))
                {
                    sensitivity = property.Value.GetString().ToSensitivity();
                    continue;
                }
                if (property.NameEquals("lowThresholds"))
                {
                    List<double> array = new List<double>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDouble());
                    }
                    lowThresholds = array;
                    continue;
                }
                if (property.NameEquals("highThresholds"))
                {
                    List<double> array = new List<double>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDouble());
                    }
                    highThresholds = array;
                    continue;
                }
            }
            return new Baseline(sensitivity, lowThresholds, highThresholds);
        }
    }
}
