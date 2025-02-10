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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The ML member abilities for a collaboration member.
    /// 
    ///  
    /// <para>
    /// Custom ML modeling is in beta release and is subject to change. For beta terms and
    /// conditions, see <i>Betas and Previews</i> in the <a href="https://aws.amazon.com/service-terms/">Amazon
    /// Web Services Service Terms</a>.
    /// </para>
    /// </summary>
    public partial class MLMemberAbilities
    {
        private List<string> _custommlMemberAbilities = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CustomMLMemberAbilities. 
        /// <para>
        /// The custom ML member abilities for a collaboration member. The inference feature is
        /// not available in the custom ML modeling beta.
        /// </para>
        ///  
        /// <para>
        /// Custom ML modeling is in beta release and is subject to change. For beta terms and
        /// conditions, see <i>Betas and Previews</i> in the <a href="https://aws.amazon.com/service-terms/">Amazon
        /// Web Services Service Terms</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> CustomMLMemberAbilities
        {
            get { return this._custommlMemberAbilities; }
            set { this._custommlMemberAbilities = value; }
        }

        // Check to see if CustomMLMemberAbilities property is set
        internal bool IsSetCustomMLMemberAbilities()
        {
            return this._custommlMemberAbilities != null && (this._custommlMemberAbilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}