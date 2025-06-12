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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
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
namespace Amazon.Budgets.Model
{
    /// <summary>
    /// The Amazon Web Services Systems Manager (SSM) action definition details.
    /// </summary>
    public partial class SsmActionDefinition
    {
        private ActionSubType _actionSubType;
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _region;

        /// <summary>
        /// Gets and sets the property ActionSubType. 
        /// <para>
        /// The action subType. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionSubType ActionSubType
        {
            get { return this._actionSubType; }
            set { this._actionSubType = value; }
        }

        // Check to see if ActionSubType property is set
        internal bool IsSetActionSubType()
        {
            return this._actionSubType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The EC2 and RDS instance IDs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && (this._instanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region to run the SSM document. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=9, Max=20)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}