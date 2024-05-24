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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// The output source for the ID mapping workflow.
    /// </summary>
    public partial class IdMappingWorkflowOutputSource
    {
        private string _kmsArn;
        private string _outputs3Path;

        /// <summary>
        /// Gets and sets the property KMSArn. 
        /// <para>
        /// Customer KMS ARN for encryption at rest. If not provided, system will use an Entity
        /// Resolution managed KMS key.
        /// </para>
        /// </summary>
        public string KMSArn
        {
            get { return this._kmsArn; }
            set { this._kmsArn = value; }
        }

        // Check to see if KMSArn property is set
        internal bool IsSetKMSArn()
        {
            return this._kmsArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutputS3Path. 
        /// <para>
        /// The S3 path to which Entity Resolution will write the output table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string OutputS3Path
        {
            get { return this._outputs3Path; }
            set { this._outputs3Path = value; }
        }

        // Check to see if OutputS3Path property is set
        internal bool IsSetOutputS3Path()
        {
            return this._outputs3Path != null;
        }

    }
}