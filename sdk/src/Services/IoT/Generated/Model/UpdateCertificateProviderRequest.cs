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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCertificateProvider operation.
    /// Updates a certificate provider.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateCertificateProvider</a>
    /// action. 
    /// </para>
    /// </summary>
    public partial class UpdateCertificateProviderRequest : AmazonIoTRequest
    {
        private List<string> _accountDefaultForOperations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _certificateProviderName;
        private string _lambdaFunctionArn;

        /// <summary>
        /// Gets and sets the property AccountDefaultForOperations. 
        /// <para>
        /// A list of the operations that the certificate provider will use to generate certificates.
        /// Valid value: <c>CreateCertificateFromCsr</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> AccountDefaultForOperations
        {
            get { return this._accountDefaultForOperations; }
            set { this._accountDefaultForOperations = value; }
        }

        // Check to see if AccountDefaultForOperations property is set
        internal bool IsSetAccountDefaultForOperations()
        {
            return this._accountDefaultForOperations != null && (this._accountDefaultForOperations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CertificateProviderName. 
        /// <para>
        /// The name of the certificate provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string CertificateProviderName
        {
            get { return this._certificateProviderName; }
            set { this._certificateProviderName = value; }
        }

        // Check to see if CertificateProviderName property is set
        internal bool IsSetCertificateProviderName()
        {
            return this._certificateProviderName != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionArn. 
        /// <para>
        /// The Lambda function ARN that's associated with the certificate provider.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string LambdaFunctionArn
        {
            get { return this._lambdaFunctionArn; }
            set { this._lambdaFunctionArn = value; }
        }

        // Check to see if LambdaFunctionArn property is set
        internal bool IsSetLambdaFunctionArn()
        {
            return this._lambdaFunctionArn != null;
        }

    }
}