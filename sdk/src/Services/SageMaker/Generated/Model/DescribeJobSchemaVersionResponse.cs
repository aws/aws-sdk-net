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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeJobSchemaVersion operation.
    /// </summary>
    public partial class DescribeJobSchemaVersionResponse : AmazonWebServiceResponse
    {
        private JobCategory _jobCategory;
        private string _jobConfigSchema;
        private string _jobConfigSchemaVersion;

        /// <summary>
        /// Gets and sets the property JobCategory. 
        /// <para>
        /// The category of the job schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobCategory JobCategory
        {
            get { return this._jobCategory; }
            set { this._jobCategory = value; }
        }

        // Check to see if JobCategory property is set
        internal bool IsSetJobCategory()
        {
            return this._jobCategory != null;
        }

        /// <summary>
        /// Gets and sets the property JobConfigSchema. 
        /// <para>
        /// The JSON schema document that defines the structure of the job configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=262144)]
        public string JobConfigSchema
        {
            get { return this._jobConfigSchema; }
            set { this._jobConfigSchema = value; }
        }

        // Check to see if JobConfigSchema property is set
        internal bool IsSetJobConfigSchema()
        {
            return this._jobConfigSchema != null;
        }

        /// <summary>
        /// Gets and sets the property JobConfigSchemaVersion. 
        /// <para>
        /// The version of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=16)]
        public string JobConfigSchemaVersion
        {
            get { return this._jobConfigSchemaVersion; }
            set { this._jobConfigSchemaVersion = value; }
        }

        // Check to see if JobConfigSchemaVersion property is set
        internal bool IsSetJobConfigSchemaVersion()
        {
            return this._jobConfigSchemaVersion != null;
        }

    }
}