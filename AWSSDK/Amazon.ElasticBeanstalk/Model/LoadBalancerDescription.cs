/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes the details of a LoadBalancer.
    /// </summary>
    public partial class LoadBalancerDescription
    {
        private string _domain;
        private List<Listener> _listeners = new List<Listener>();
        private string _loadBalancerName;


        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain name of the LoadBalancer.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }


        /// <summary>
        /// Sets the Domain property
        /// </summary>
        /// <param name="domain">The value to set for the Domain property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LoadBalancerDescription WithDomain(string domain)
        {
            this._domain = domain;
            return this;
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }


        /// <summary>
        /// Gets and sets the property Listeners. 
        /// <para>
        /// A list of Listeners used by the LoadBalancer.
        /// </para>
        /// </summary>
        public List<Listener> Listeners
        {
            get { return this._listeners; }
            set { this._listeners = value; }
        }

        /// <summary>
        /// Sets the Listeners property
        /// </summary>
        /// <param name="listeners">The values to add to the Listeners collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LoadBalancerDescription WithListeners(params Listener[] listeners)
        {
            foreach (var element in listeners)
            {
                this._listeners.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Listeners property
        /// </summary>
        /// <param name="listeners">The values to add to the Listeners collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LoadBalancerDescription WithListeners(IEnumerable<Listener> listeners)
        {
            foreach (var element in listeners)
            {
                this._listeners.Add(element);
            }
            return this;
        }
        // Check to see if Listeners property is set
        internal bool IsSetListeners()
        {
            return this._listeners != null && this._listeners.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the LoadBalancer.
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }


        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The value to set for the LoadBalancerName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LoadBalancerDescription WithLoadBalancerName(string loadBalancerName)
        {
            this._loadBalancerName = loadBalancerName;
            return this;
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

    }
}