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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Configuration for a single Parameter in the Amazon Web Services Systems Manager (SSM)
    /// Parameter Store in a given Region.
    /// </summary>
    public partial class SsmParameterConfiguration
    {
        /// <summary>
        /// Gets and sets the property AmiAccountId. 
        /// <para>
        /// Specify the account that will own the Parameter in a given Region. During distribution,
        /// this account must be specified in distribution settings as a target account for the
        /// Region.
        /// </para>
        /// </summary>
        public string AmiAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AmiAccountId property is set.
        /// </summary>
        internal bool IsSetAmiAccountId() => this.AmiAccountId != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The type of value the parameter contains. We recommend the <c>aws:ec2:image</c> data
        /// type.
        /// </para>
        /// </summary>
        public SsmParameterDataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// This is the name of the Parameter in the target Region or account. The image distribution
        /// creates the Parameter if it doesn't already exist. Otherwise, it updates the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ParameterName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterName property is set.
        /// </summary>
        internal bool IsSetParameterName() => this.ParameterName != null;
    }
}
