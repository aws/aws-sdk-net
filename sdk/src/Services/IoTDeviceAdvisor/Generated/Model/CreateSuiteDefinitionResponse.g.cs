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

namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// This is the response object from the CreateSuiteDefinition operation.
    /// </summary>
    public partial class CreateSuiteDefinitionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the test suite was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SuiteDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string SuiteDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the SuiteDefinitionArn property is set.
        /// </summary>
        internal bool IsSetSuiteDefinitionArn() => this.SuiteDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property SuiteDefinitionId. 
        /// <para>
        /// The UUID of the test suite created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string SuiteDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the SuiteDefinitionId property is set.
        /// </summary>
        internal bool IsSetSuiteDefinitionId() => this.SuiteDefinitionId != null;

        /// <summary>
        /// Gets and sets the property SuiteDefinitionName. 
        /// <para>
        /// The suite definition name of the test suite. This is a required parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SuiteDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the SuiteDefinitionName property is set.
        /// </summary>
        internal bool IsSetSuiteDefinitionName() => this.SuiteDefinitionName != null;
    }
}
