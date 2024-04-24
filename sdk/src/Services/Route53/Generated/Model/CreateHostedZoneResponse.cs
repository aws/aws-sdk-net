/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type containing the response information for the hosted zone.
    /// </summary>
    public partial class CreateHostedZoneResponse : AmazonWebServiceResponse
    {
        private HostedZone _hostedZone;
        private ChangeInfo _changeInfo;
        private DelegationSet _delegationSet;
        private VPC _vpc;
        private string _location;

        /// <summary>
        /// Gets and sets the property HostedZone. 
        /// <para>
        /// A complex type that contains general information about the hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HostedZone HostedZone
        {
            get { return this._hostedZone; }
            set { this._hostedZone = value; }
        }

        // Check to see if HostedZone property is set
        internal bool IsSetHostedZone()
        {
            return this._hostedZone != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeInfo. 
        /// <para>
        /// A complex type that contains information about the <c>CreateHostedZone</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChangeInfo ChangeInfo
        {
            get { return this._changeInfo; }
            set { this._changeInfo = value; }
        }

        // Check to see if ChangeInfo property is set
        internal bool IsSetChangeInfo()
        {
            return this._changeInfo != null;
        }

        /// <summary>
        /// Gets and sets the property DelegationSet. 
        /// <para>
        /// A complex type that describes the name servers for this hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DelegationSet DelegationSet
        {
            get { return this._delegationSet; }
            set { this._delegationSet = value; }
        }

        // Check to see if DelegationSet property is set
        internal bool IsSetDelegationSet()
        {
            return this._delegationSet != null;
        }

        /// <summary>
        /// Gets and sets the property VPC. 
        /// <para>
        /// A complex type that contains information about an Amazon VPC that you associated with
        /// this hosted zone.
        /// </para>
        /// </summary>
        public VPC VPC
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if VPC property is set
        internal bool IsSetVPC()
        {
            return this._vpc != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The unique URL representing the new hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}