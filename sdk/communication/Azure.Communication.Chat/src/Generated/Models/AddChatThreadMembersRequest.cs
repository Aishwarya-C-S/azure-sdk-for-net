// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.Chat
{
    /// <summary> Thread members to be added to the thread. </summary>
    internal partial class AddChatThreadMembersRequest
    {
        /// <summary> Initializes a new instance of AddChatThreadMembersRequest. </summary>
        /// <param name="members"> Members to add to a chat thread. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="members"/> is null. </exception>
        public AddChatThreadMembersRequest(IEnumerable<ChatThreadMemberInternal> members)
        {
            if (members == null)
            {
                throw new ArgumentNullException(nameof(members));
            }

            Members = members.ToList();
        }

        /// <summary> Members to add to a chat thread. </summary>
        public IList<ChatThreadMemberInternal> Members { get; }
    }
}
