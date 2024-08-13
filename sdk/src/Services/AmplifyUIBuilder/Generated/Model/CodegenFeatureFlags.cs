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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the feature flags that you can specify for a code generation job.
    /// </summary>
    public partial class CodegenFeatureFlags
    {
        private bool? _isNonModelSupported;
        private bool? _isRelationshipSupported;

        /// <summary>
        /// Gets and sets the property IsNonModelSupported. 
        /// <para>
        /// Specifies whether a code generation job supports non models.
        /// </para>
        /// </summary>
        public bool? IsNonModelSupported
        {
            get { return this._isNonModelSupported; }
            set { this._isNonModelSupported = value; }
        }

        // Check to see if IsNonModelSupported property is set
        internal bool IsSetIsNonModelSupported()
        {
            return this._isNonModelSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsRelationshipSupported. 
        /// <para>
        /// Specifes whether a code generation job supports data relationships.
        /// </para>
        /// </summary>
        public bool? IsRelationshipSupported
        {
            get { return this._isRelationshipSupported; }
            set { this._isRelationshipSupported = value; }
        }

        // Check to see if IsRelationshipSupported property is set
        internal bool IsSetIsRelationshipSupported()
        {
            return this._isRelationshipSupported.HasValue; 
        }

    }
}