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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Provides replication details for objects stored in the Amazon Security Lake data lake.
    /// </summary>
    public partial class DataLakeReplicationConfiguration
    {
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// Specifies one or more centralized rollup Regions. The Amazon Web Services Region specified
        /// in the <c>region</c> parameter of the <a href="https://docs.aws.amazon.com/security-lake/latest/APIReference/API_CreateDataLake.html">
        /// <c>CreateDataLake</c> </a> or <a href="https://docs.aws.amazon.com/security-lake/latest/APIReference/API_UpdateDataLake.html">
        /// <c>UpdateDataLake</c> </a> operations contributes data to the rollup Region or Regions
        /// specified in this parameter.
        /// </para>
        ///  
        /// <para>
        /// Replication enables automatic, asynchronous copying of objects across Amazon S3 buckets.
        /// S3 buckets that are configured for object replication can be owned by the same Amazon
        /// Web Services account or by different accounts. You can replicate objects to a single
        /// destination bucket or to multiple destination buckets. The destination buckets can
        /// be in different Regions or within the same Region as the source bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// Replication settings for the Amazon S3 buckets. This parameter uses the Identity and
        /// Access Management (IAM) role you created that is managed by Security Lake, to ensure
        /// the replication setting is correct.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}