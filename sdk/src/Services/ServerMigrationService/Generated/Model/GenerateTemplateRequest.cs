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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the GenerateTemplate operation.
    /// Generates an AWS CloudFormation template based on the current launch configuration
    /// and writes it to an Amazon S3 object in the customer’s Amazon S3 bucket.
    /// </summary>
    public partial class GenerateTemplateRequest : AmazonServerMigrationServiceRequest
    {
        private string _appId;
        private OutputFormat _templateFormat;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The ID of the application associated with the AWS CloudFormation template.
        /// </para>
        /// </summary>
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateFormat. 
        /// <para>
        /// The format for generating the AWS CloudFormation template.
        /// </para>
        /// </summary>
        public OutputFormat TemplateFormat
        {
            get { return this._templateFormat; }
            set { this._templateFormat = value; }
        }

        // Check to see if TemplateFormat property is set
        internal bool IsSetTemplateFormat()
        {
            return this._templateFormat != null;
        }

    }
}