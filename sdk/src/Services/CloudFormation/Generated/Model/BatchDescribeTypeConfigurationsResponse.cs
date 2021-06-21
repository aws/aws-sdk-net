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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the BatchDescribeTypeConfigurations operation.
    /// </summary>
    public partial class BatchDescribeTypeConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<BatchDescribeTypeConfigurationsError> _errors = new List<BatchDescribeTypeConfigurationsError>();
        private List<TypeConfigurationDetails> _typeConfigurations = new List<TypeConfigurationDetails>();
        private List<TypeConfigurationIdentifier> _unprocessedTypeConfigurations = new List<TypeConfigurationIdentifier>();

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of information concerning any errors generated during the setting of the specified
        /// configurations.
        /// </para>
        /// </summary>
        public List<BatchDescribeTypeConfigurationsError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TypeConfigurations. 
        /// <para>
        /// A list of any of the specified extension configurations from the CloudFormation registry.
        /// </para>
        /// </summary>
        public List<TypeConfigurationDetails> TypeConfigurations
        {
            get { return this._typeConfigurations; }
            set { this._typeConfigurations = value; }
        }

        // Check to see if TypeConfigurations property is set
        internal bool IsSetTypeConfigurations()
        {
            return this._typeConfigurations != null && this._typeConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedTypeConfigurations. 
        /// <para>
        /// A list of any of the specified extension configurations that CloudFormation could
        /// not process for any reason.
        /// </para>
        /// </summary>
        public List<TypeConfigurationIdentifier> UnprocessedTypeConfigurations
        {
            get { return this._unprocessedTypeConfigurations; }
            set { this._unprocessedTypeConfigurations = value; }
        }

        // Check to see if UnprocessedTypeConfigurations property is set
        internal bool IsSetUnprocessedTypeConfigurations()
        {
            return this._unprocessedTypeConfigurations != null && this._unprocessedTypeConfigurations.Count > 0; 
        }

    }
}