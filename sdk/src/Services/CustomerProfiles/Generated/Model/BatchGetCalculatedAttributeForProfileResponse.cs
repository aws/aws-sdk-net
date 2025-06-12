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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
        private List<CalculatedAttributeValue> _calculatedAttributeValues = AWSConfigs.InitializeCollections ? new List<CalculatedAttributeValue>() : null;
        private ConditionOverrides _conditionOverrides;
        private List<BatchGetCalculatedAttributeForProfileError> _errors = AWSConfigs.InitializeCollections ? new List<BatchGetCalculatedAttributeForProfileError>() : null;

        /// <summary>
        /// Gets and sets the property CalculatedAttributeValues. 
        /// <para>
        /// List of calculated attribute values retrieved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CalculatedAttributeValue> CalculatedAttributeValues
        {
            get { return this._calculatedAttributeValues; }
            set { this._calculatedAttributeValues = value; }
        }

        // Check to see if CalculatedAttributeValues property is set
        internal bool IsSetCalculatedAttributeValues()
        {
            return this._calculatedAttributeValues != null && (this._calculatedAttributeValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConditionOverrides. 
        /// <para>
        /// Overrides the condition block within the original calculated attribute definition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ConditionOverrides ConditionOverrides
        {
            get { return this._conditionOverrides; }
            set { this._conditionOverrides = value; }
        }

        // Check to see if ConditionOverrides property is set
        internal bool IsSetConditionOverrides()
        {
            return this._conditionOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// List of errors for calculated attribute values that could not be retrieved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BatchGetCalculatedAttributeForProfileError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}