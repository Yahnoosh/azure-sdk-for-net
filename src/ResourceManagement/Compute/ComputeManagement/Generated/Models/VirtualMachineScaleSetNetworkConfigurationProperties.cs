// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes a virtual machine scale set network profile's IP
    /// configuration.
    /// </summary>
    public partial class VirtualMachineScaleSetNetworkConfigurationProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetNetworkConfigurationProperties class.
        /// </summary>
        public VirtualMachineScaleSetNetworkConfigurationProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetNetworkConfigurationProperties class.
        /// </summary>
        public VirtualMachineScaleSetNetworkConfigurationProperties(bool? primary = default(bool?), IList<VirtualMachineScaleSetIPConfiguration> ipConfigurations = default(IList<VirtualMachineScaleSetIPConfiguration>))
        {
            Primary = primary;
            IpConfigurations = ipConfigurations;
        }

        /// <summary>
        /// Gets or sets whether this is a primary NIC on a virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "primary")]
        public bool? Primary { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set IP Configuration.
        /// </summary>
        [JsonProperty(PropertyName = "ipConfigurations")]
        public IList<VirtualMachineScaleSetIPConfiguration> IpConfigurations { get; set; }

    }
}