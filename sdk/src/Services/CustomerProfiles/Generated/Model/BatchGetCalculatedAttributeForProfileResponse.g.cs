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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the BatchGetCalculatedAttributeForProfile operation.
    /// </summary>
    public partial class BatchGetCalculatedAttributeForProfileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CalculatedAttributeValues. 
        /// <para>
        /// List of calculated attribute values retrieved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CalculatedAttributeValue> CalculatedAttributeValues { get; set; } = AWSConfigs.InitializeCollections ? new List<CalculatedAttributeValue>() : null;

        /// <summary>
        /// Checks to see if the CalculatedAttributeValues property is set.
        /// </summary>
        internal bool IsSetCalculatedAttributeValues() => this.CalculatedAttributeValues != null && (this.CalculatedAttributeValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConditionOverrides. 
        /// <para>
        /// Overrides the condition block within the original calculated attribute definition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ConditionOverrides ConditionOverrides { get; set; }

        /// <summary>
        /// Checks to see if the ConditionOverrides property is set.
        /// </summary>
        internal bool IsSetConditionOverrides() => this.ConditionOverrides != null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// List of errors for calculated attribute values that could not be retrieved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BatchGetCalculatedAttributeForProfileError> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchGetCalculatedAttributeForProfileError>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
