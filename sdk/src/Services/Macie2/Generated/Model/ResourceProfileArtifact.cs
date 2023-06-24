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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about an S3 object that Amazon Macie selected for analysis while
    /// performing automated sensitive data discovery for an S3 bucket, and the status and
    /// results of the analysis. This information is available only if automated sensitive
    /// data discovery is currently enabled for your account.
    /// </summary>
    public partial class ResourceProfileArtifact
    {
        private string _arn;
        private string _classificationResultStatus;
        private bool? _sensitive;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClassificationResultStatus. 
        /// <para>
        /// The status of the analysis. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// COMPLETE - Amazon Macie successfully completed its analysis of the object.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PARTIAL - Macie analyzed only a subset of data in the object. For example, the object
        /// is an archive file that contains files in an unsupported format.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SKIPPED - Macie wasn't able to analyze the object. For example, the object is a malformed
        /// file.
        /// </para>
        /// </li></ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClassificationResultStatus
        {
            get { return this._classificationResultStatus; }
            set { this._classificationResultStatus = value; }
        }

        // Check to see if ClassificationResultStatus property is set
        internal bool IsSetClassificationResultStatus()
        {
            return this._classificationResultStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Sensitive. 
        /// <para>
        /// Specifies whether Amazon Macie found sensitive data in the object.
        /// </para>
        /// </summary>
        public bool Sensitive
        {
            get { return this._sensitive.GetValueOrDefault(); }
            set { this._sensitive = value; }
        }

        // Check to see if Sensitive property is set
        internal bool IsSetSensitive()
        {
            return this._sensitive.HasValue; 
        }

    }
}