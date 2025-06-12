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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A set of TCP flags and masks to inspect for.
    /// </summary>
    public partial class RuleGroupSourceStatelessRuleMatchAttributesTcpFlags
    {
        private List<string> _flags = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _masks = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Flags. 
        /// <para>
        /// Defines the flags from the <c>Masks</c> setting that must be set in order for the
        /// packet to match. Flags that are listed must be set. Flags that are not listed must
        /// not be set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Flags
        {
            get { return this._flags; }
            set { this._flags = value; }
        }

        // Check to see if Flags property is set
        internal bool IsSetFlags()
        {
            return this._flags != null && (this._flags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Masks. 
        /// <para>
        /// The set of flags to consider in the inspection. If not specified, then all flags are
        /// inspected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Masks
        {
            get { return this._masks; }
            set { this._masks = value; }
        }

        // Check to see if Masks property is set
        internal bool IsSetMasks()
        {
            return this._masks != null && (this._masks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}