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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the PutSigningConfiguration operation.
    /// Creates or updates the registry's signing configuration, which defines rules for automatically
    /// signing images with Amazon Web Services Signer.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/managed-signing.html">Managed
    /// signing</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// To successfully generate a signature, the IAM principal pushing images must have permission
    /// to sign payloads with the Amazon Web Services Signer signing profile referenced in
    /// the signing configuration.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutSigningConfigurationRequest : AmazonECRRequest
    {
        private SigningConfiguration _signingConfiguration;

        /// <summary>
        /// Gets and sets the property SigningConfiguration. 
        /// <para>
        /// The signing configuration to assign to the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SigningConfiguration SigningConfiguration
        {
            get { return this._signingConfiguration; }
            set { this._signingConfiguration = value; }
        }

        // Check to see if SigningConfiguration property is set
        internal bool IsSetSigningConfiguration()
        {
            return this._signingConfiguration != null;
        }

    }
}