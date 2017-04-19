/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the GetBot operation.
    /// Returns metadata information for a specific bot. You must provide the bot name and
    /// the bot version or alias. 
    /// 
    ///  
    /// <para>
    ///  The GetBot operation requires permissions for the <code>lex:GetBot</code> action.
    /// 
    /// </para>
    /// </summary>
    public partial class GetBotRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _name;
        private string _versionOrAlias;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bot. The name is case sensitive. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property VersionOrAlias. 
        /// <para>
        /// The version or alias of the bot.
        /// </para>
        /// </summary>
        public string VersionOrAlias
        {
            get { return this._versionOrAlias; }
            set { this._versionOrAlias = value; }
        }

        // Check to see if VersionOrAlias property is set
        internal bool IsSetVersionOrAlias()
        {
            return this._versionOrAlias != null;
        }

    }
}