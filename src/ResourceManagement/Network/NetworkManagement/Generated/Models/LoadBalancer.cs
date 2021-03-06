// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// LoadBalancer resource
    /// </summary>
    public partial class LoadBalancer : TopLevelResource
    {
        private IList<BackendAddressPool> _backendAddressPools;
        
        /// <summary>
        /// Optional. Gets or sets Pools of backend IP addresseses
        /// </summary>
        public IList<BackendAddressPool> BackendAddressPools
        {
            get { return this._backendAddressPools; }
            set { this._backendAddressPools = value; }
        }
        
        private IList<FrontendIpConfiguration> _frontendIpConfigurations;
        
        /// <summary>
        /// Optional. Gets or sets frontend IP addresses of the load balancer
        /// </summary>
        public IList<FrontendIpConfiguration> FrontendIpConfigurations
        {
            get { return this._frontendIpConfigurations; }
            set { this._frontendIpConfigurations = value; }
        }
        
        private IList<InboundNatRule> _inboundNatRules;
        
        /// <summary>
        /// Optional. Gets or sets list of inbound rules
        /// </summary>
        public IList<InboundNatRule> InboundNatRules
        {
            get { return this._inboundNatRules; }
            set { this._inboundNatRules = value; }
        }
        
        private IList<LoadBalancingRule> _loadBalancingRules;
        
        /// <summary>
        /// Optional. Gets or sets loadbalancing rules
        /// </summary>
        public IList<LoadBalancingRule> LoadBalancingRules
        {
            get { return this._loadBalancingRules; }
            set { this._loadBalancingRules = value; }
        }
        
        private IList<Probe> _probes;
        
        /// <summary>
        /// Optional. Gets or sets list of Load balancer probes
        /// </summary>
        public IList<Probe> Probes
        {
            get { return this._probes; }
            set { this._probes = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets Provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the LoadBalancer class.
        /// </summary>
        public LoadBalancer()
        {
            this.BackendAddressPools = new LazyList<BackendAddressPool>();
            this.FrontendIpConfigurations = new LazyList<FrontendIpConfiguration>();
            this.InboundNatRules = new LazyList<InboundNatRule>();
            this.LoadBalancingRules = new LazyList<LoadBalancingRule>();
            this.Probes = new LazyList<Probe>();
        }
        
        /// <summary>
        /// Initializes a new instance of the LoadBalancer class with required
        /// arguments.
        /// </summary>
        public LoadBalancer(string location)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.Location = location;
        }
    }
}
