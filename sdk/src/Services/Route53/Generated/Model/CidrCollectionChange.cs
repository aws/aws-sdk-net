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
    /// A complex type that contains information about the CIDR collection change.
    /// </summary>
    public partial class CidrCollectionChange
    {
        private string _locationName;
        private CidrCollectionChangeAction _action;
        private List<string> _cidrList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property LocationName. 
        /// <para>
        /// Name of the location that is associated with the CIDR collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public string LocationName
        {
            get { return this._locationName; }
            set { this._locationName = value; }
        }

        // Check to see if LocationName property is set
        internal bool IsSetLocationName()
        {
            return this._locationName != null;
        }

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// CIDR collection change action. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CidrCollectionChangeAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property CidrList. 
        /// <para>
        /// List of CIDR blocks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public List<string> CidrList
        {
            get { return this._cidrList; }
            set { this._cidrList = value; }
        }

        // Check to see if CidrList property is set
        internal bool IsSetCidrList()
        {
            return this._cidrList != null && (this._cidrList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}