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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the ValidateAssessmentReportIntegrity operation.
    /// Validates the integrity of an assessment report in Audit Manager.
    /// </summary>
    public partial class ValidateAssessmentReportIntegrityRequest : AmazonAuditManagerRequest
    {
        private string _s3RelativePath;

        /// <summary>
        /// Gets and sets the property S3RelativePath. 
        /// <para>
        ///  The relative path of the Amazon S3 bucket that the assessment report is stored in.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string S3RelativePath
        {
            get { return this._s3RelativePath; }
            set { this._s3RelativePath = value; }
        }

        // Check to see if S3RelativePath property is set
        internal bool IsSetS3RelativePath()
        {
            return this._s3RelativePath != null;
        }

    }
}