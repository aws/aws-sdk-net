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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// A policy configures behavior that you allow or disallow for your account. For information
    /// about MediaConvert policies, see the user guide at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
    /// </summary>
    public partial class Policy
    {
        /// <summary>
        /// Gets and sets the property HttpInputs. Allow or disallow jobs that specify HTTP inputs.
        /// </summary>
        public InputPolicy HttpInputs { get; set; }

        /// <summary>
        /// Checks to see if the HttpInputs property is set.
        /// </summary>
        internal bool IsSetHttpInputs() => this.HttpInputs != null;

        /// <summary>
        /// Gets and sets the property HttpsInputs. Allow or disallow jobs that specify HTTPS
        /// inputs.
        /// </summary>
        public InputPolicy HttpsInputs { get; set; }

        /// <summary>
        /// Checks to see if the HttpsInputs property is set.
        /// </summary>
        internal bool IsSetHttpsInputs() => this.HttpsInputs != null;

        /// <summary>
        /// Gets and sets the property S3Inputs. Allow or disallow jobs that specify Amazon S3
        /// inputs.
        /// </summary>
        public InputPolicy S3Inputs { get; set; }

        /// <summary>
        /// Checks to see if the S3Inputs property is set.
        /// </summary>
        internal bool IsSetS3Inputs() => this.S3Inputs != null;
    }
}
