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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Configuration settings that define the scope of Amazon Web Services resources to analyze
    /// for optimization recommendations.
    /// </summary>
    public partial class AggregationConfiguration
    {
        private string _accessRoleArn;
        private string _accountId;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccessRoleArn. 
        /// <para>
        /// The ARN of an IAM role to assume for resource analysis in this account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string AccessRoleArn
        {
            get { return this._accessRoleArn; }
            set { this._accessRoleArn = value; }
        }

        // Check to see if AccessRoleArn property is set
        internal bool IsSetAccessRoleArn()
        {
            return this._accessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID to analyze.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// A list of Amazon Web Services Regions to include in the analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}