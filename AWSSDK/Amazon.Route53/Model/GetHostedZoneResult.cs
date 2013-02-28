/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <para>A complex type containing information about the specified hosted zone.</para>
    /// </summary>
    public class GetHostedZoneResult
    {
        
        private HostedZone hostedZone;
        private DelegationSet delegationSet;

        /// <summary>
        /// A complex type that contains the information about the specified hosted zone.
        ///  
        /// </summary>
        public HostedZone HostedZone
        {
            get { return this.hostedZone; }
            set { this.hostedZone = value; }
        }

        /// <summary>
        /// Sets the HostedZone property
        /// </summary>
        /// <param name="hostedZone">The value to set for the HostedZone property </param>
        /// <returns>this instance</returns>
        public GetHostedZoneResult WithHostedZone(HostedZone hostedZone)
        {
            this.hostedZone = hostedZone;
            return this;
        }
            

        // Check to see if HostedZone property is set
        internal bool IsSetHostedZone()
        {
            return this.hostedZone != null;
        }

        /// <summary>
        /// A complex type that contains information about the name servers for the specified hosted zone.
        ///  
        /// </summary>
        public DelegationSet DelegationSet
        {
            get { return this.delegationSet; }
            set { this.delegationSet = value; }
        }

        /// <summary>
        /// Sets the DelegationSet property
        /// </summary>
        /// <param name="delegationSet">The value to set for the DelegationSet property </param>
        /// <returns>this instance</returns>
        public GetHostedZoneResult WithDelegationSet(DelegationSet delegationSet)
        {
            this.delegationSet = delegationSet;
            return this;
        }
            

        // Check to see if DelegationSet property is set
        internal bool IsSetDelegationSet()
        {
            return this.delegationSet != null;
        }
    }
}
