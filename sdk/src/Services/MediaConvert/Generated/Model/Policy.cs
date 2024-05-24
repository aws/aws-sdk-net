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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
        private InputPolicy _httpInputs;
        private InputPolicy _httpsInputs;
        private InputPolicy _s3Inputs;

        /// <summary>
        /// Gets and sets the property HttpInputs. Allow or disallow jobs that specify HTTP inputs.
        /// </summary>
        public InputPolicy HttpInputs
        {
            get { return this._httpInputs; }
            set { this._httpInputs = value; }
        }

        // Check to see if HttpInputs property is set
        internal bool IsSetHttpInputs()
        {
            return this._httpInputs != null;
        }

        /// <summary>
        /// Gets and sets the property HttpsInputs. Allow or disallow jobs that specify HTTPS
        /// inputs.
        /// </summary>
        public InputPolicy HttpsInputs
        {
            get { return this._httpsInputs; }
            set { this._httpsInputs = value; }
        }

        // Check to see if HttpsInputs property is set
        internal bool IsSetHttpsInputs()
        {
            return this._httpsInputs != null;
        }

        /// <summary>
        /// Gets and sets the property S3Inputs. Allow or disallow jobs that specify Amazon S3
        /// inputs.
        /// </summary>
        public InputPolicy S3Inputs
        {
            get { return this._s3Inputs; }
            set { this._s3Inputs = value; }
        }

        // Check to see if S3Inputs property is set
        internal bool IsSetS3Inputs()
        {
            return this._s3Inputs != null;
        }

    }
}