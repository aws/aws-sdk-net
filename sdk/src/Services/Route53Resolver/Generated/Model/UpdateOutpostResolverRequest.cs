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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateOutpostResolver operation.
    /// You can use <c>UpdateOutpostResolver</c> to update the instance count, type, or name
    /// of a Resolver on an Outpost.
    /// </summary>
    public partial class UpdateOutpostResolverRequest : AmazonRoute53ResolverRequest
    {
        private string _id;
        private int? _instanceCount;
        private string _name;
        private string _preferredInstanceType;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique string that identifies Resolver on an Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The Amazon EC2 instance count for a Resolver on the Outpost.
        /// </para>
        /// </summary>
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the Resolver on the Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredInstanceType. 
        /// <para>
        ///  Amazon EC2 instance type. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PreferredInstanceType
        {
            get { return this._preferredInstanceType; }
            set { this._preferredInstanceType = value; }
        }

        // Check to see if PreferredInstanceType property is set
        internal bool IsSetPreferredInstanceType()
        {
            return this._preferredInstanceType != null;
        }

    }
}