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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Configuration for a single Parameter in the Amazon Web Services Systems Manager (SSM)
    /// Parameter Store in a given Region.
    /// </summary>
    public partial class SsmParameterConfiguration
    {
        private string _amiAccountId;
        private SsmParameterDataType _dataType;
        private string _parameterName;

        /// <summary>
        /// Gets and sets the property AmiAccountId. 
        /// <para>
        /// Specify the account that will own the Parameter in a given Region. During distribution,
        /// this account must be specified in distribution settings as a target account for the
        /// Region.
        /// </para>
        /// </summary>
        public string AmiAccountId
        {
            get { return this._amiAccountId; }
            set { this._amiAccountId = value; }
        }

        // Check to see if AmiAccountId property is set
        internal bool IsSetAmiAccountId()
        {
            return this._amiAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type specifies what type of value the Parameter contains. We recommend that
        /// you use data type <c>aws:ec2:image</c>.
        /// </para>
        /// </summary>
        public SsmParameterDataType DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// This is the name of the Parameter in the target Region or account. The image distribution
        /// creates the Parameter if it doesn't already exist. Otherwise, it updates the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ParameterName
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this._parameterName != null;
        }

    }
}