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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteServiceLinkedConfigurationRecorder operation.
    /// Deletes an existing service-linked configuration recorder.
    /// 
    ///  
    /// <para>
    /// This operation does not delete the configuration information that was previously recorded.
    /// You will be able to access the previously recorded information by using the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_GetResourceConfigHistory.html">GetResourceConfigHistory</a>
    /// operation, but you will not be able to access this information in the Config console
    /// until you have created a new service-linked configuration recorder for the same service.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>The recording scope determines if you receive configuration items</b> 
    /// </para>
    ///  
    /// <para>
    /// The recording scope is set by the service that is linked to the configuration recorder
    /// and determines whether you receive configuration items (CIs) in the delivery channel.
    /// If the recording scope is internal, you will not receive CIs in the delivery channel.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteServiceLinkedConfigurationRecorderRequest : AmazonConfigServiceRequest
    {
        private string _arn;
        private string _servicePrincipal;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service-linked configuration recorder that you
        /// want to delete. For third-party service-linked configuration recorders, you must use
        /// <c>Arn</c>. You must specify exactly one of <c>Arn</c> or <c>ServicePrincipal</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// The service principal of the Amazon Web Services service for the service-linked configuration
        /// recorder that you want to delete. This field is only supported for Amazon Web Services
        /// service principals. For third-party service-linked configuration recorders, use <c>Arn</c>
        /// instead.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ServicePrincipal
        {
            get { return this._servicePrincipal; }
            set { this._servicePrincipal = value; }
        }

        // Check to see if ServicePrincipal property is set
        internal bool IsSetServicePrincipal()
        {
            return this._servicePrincipal != null;
        }

    }
}