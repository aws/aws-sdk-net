/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Attributes that define a secret resource, which references a secret from AWS Secrets
    /// Manager. AWS IoT Greengrass stores a local, encrypted copy of the secret on the Greengrass
    /// core, where it can be securely accessed by connectors and Lambda functions.
    /// </summary>
    public partial class SecretsManagerSecretResourceData
    {
        private List<string> _additionalStagingLabelsToDownload = new List<string>();
        private string _arn;

        /// <summary>
        /// Gets and sets the property AdditionalStagingLabelsToDownload. Optional. The staging
        /// labels whose values you want to make available on the core, in addition to ''AWSCURRENT''.
        /// </summary>
        public List<string> AdditionalStagingLabelsToDownload
        {
            get { return this._additionalStagingLabelsToDownload; }
            set { this._additionalStagingLabelsToDownload = value; }
        }

        // Check to see if AdditionalStagingLabelsToDownload property is set
        internal bool IsSetAdditionalStagingLabelsToDownload()
        {
            return this._additionalStagingLabelsToDownload != null && this._additionalStagingLabelsToDownload.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ARN. The ARN of the Secrets Manager secret to make available
        /// on the core. The value of the secret's latest version (represented by the ''AWSCURRENT''
        /// staging label) is included by default.
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

    }
}