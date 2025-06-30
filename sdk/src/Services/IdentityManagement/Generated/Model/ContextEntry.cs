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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about a condition context key. It includes the name of the key
    /// and specifies the value (or values, if the context key supports multiple values) to
    /// use in the simulation. This information is used when evaluating the <c>Condition</c>
    /// elements of the input policies.
    /// 
    ///  
    /// <para>
    /// This data type is used as an input parameter to <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulateCustomPolicy.html">SimulateCustomPolicy</a>
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulatePrincipalPolicy.html">SimulatePrincipalPolicy</a>.
    /// </para>
    /// </summary>
    public partial class ContextEntry
    {
        private string _contextKeyName;
        private ContextKeyTypeEnum _contextKeyType;
        private List<string> _contextKeyValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ContextKeyName. 
        /// <para>
        /// The full name of a condition context key, including the service prefix. For example,
        /// <c>aws:SourceIp</c> or <c>s3:VersionId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=256)]
        public string ContextKeyName
        {
            get { return this._contextKeyName; }
            set { this._contextKeyName = value; }
        }

        // Check to see if ContextKeyName property is set
        internal bool IsSetContextKeyName()
        {
            return this._contextKeyName != null;
        }

        /// <summary>
        /// Gets and sets the property ContextKeyType. 
        /// <para>
        /// The data type of the value (or values) specified in the <c>ContextKeyValues</c> parameter.
        /// </para>
        /// </summary>
        public ContextKeyTypeEnum ContextKeyType
        {
            get { return this._contextKeyType; }
            set { this._contextKeyType = value; }
        }

        // Check to see if ContextKeyType property is set
        internal bool IsSetContextKeyType()
        {
            return this._contextKeyType != null;
        }

        /// <summary>
        /// Gets and sets the property ContextKeyValues. 
        /// <para>
        /// The value (or values, if the condition context key supports multiple values) to provide
        /// to the simulation when the key is referenced by a <c>Condition</c> element in an input
        /// policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ContextKeyValues
        {
            get { return this._contextKeyValues; }
            set { this._contextKeyValues = value; }
        }

        // Check to see if ContextKeyValues property is set
        internal bool IsSetContextKeyValues()
        {
            return this._contextKeyValues != null && (this._contextKeyValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}