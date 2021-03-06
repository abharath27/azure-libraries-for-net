// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Dns.Fluent
{
    using Microsoft.Azure.Management.Dns.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    internal partial class PtrRecordSetsImpl
    {
        /// <summary>
        /// Gets the information about a resource from Azure based on the resource name within the current resource group.
        /// </summary>
        /// <param name="name">The name of the resource. (Note, this is not the resource ID.).</param>
        /// <return>An immutable representation of the resource.</return>
        Microsoft.Azure.Management.Dns.Fluent.IPtrRecordSet Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsGettingByName<Microsoft.Azure.Management.Dns.Fluent.IPtrRecordSet>.GetByName(string name)
        {
            return this.GetByName(name) as Microsoft.Azure.Management.Dns.Fluent.IPtrRecordSet;
        }
    }
}