// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class MessageResult
    {
        internal static MessageResult DeserializeMessageResult(JsonElement element)
        {
            string messageId = default;
            string deviceId = default;
            DateTimeOffset? enqueuedTimeUtc = default;
            MessageResultStatusCode? statusCode = default;
            string status = default;
            string deviceGenerationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enqueuedTimeUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enqueuedTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("statusCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusCode = new MessageResultStatusCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceGenerationId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceGenerationId = property.Value.GetString();
                    continue;
                }
            }
            return new MessageResult(messageId, deviceId, enqueuedTimeUtc, statusCode, status, deviceGenerationId);
        }
    }
}