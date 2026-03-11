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
    /// Container for the parameters to the DescribeConfigurationRecorders operation.
    /// Returns details for the configuration recorder you specify.
    /// 
    ///  
    /// <para>
    /// If a configuration recorder is not specified, this operation returns details for the
    /// customer managed configuration recorder configured for the account, if applicable.
    /// </para>
    ///  <note> 
    /// <para>
    /// When making a request to this operation, you can only specify one configuration recorder.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeConfigurationRecordersRequest : AmazonConfigServiceRequest
    {
        private string _arn;
        private List<string> _configurationRecorderNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _servicePrincipal;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configuration recorder that you want to specify.
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
        /// Gets and sets the property ConfigurationRecorderNames. 
        /// <para>
        /// A list of names of the configuration recorders that you want to specify.
        /// </para>
        ///  <note> 
        /// <para>
        /// When making a request to this operation, you can only specify one configuration recorder.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConfigurationRecorderNames
        {
            get { return this._configurationRecorderNames; }
            set { this._configurationRecorderNames = value; }
        }

        // Check to see if ConfigurationRecorderNames property is set
        internal bool IsSetConfigurationRecorderNames()
        {
            return this._configurationRecorderNames != null && (this._configurationRecorderNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// For service-linked configuration recorders, you can use the service principal of the
        /// linked Amazon Web Services service to specify the configuration recorder.
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