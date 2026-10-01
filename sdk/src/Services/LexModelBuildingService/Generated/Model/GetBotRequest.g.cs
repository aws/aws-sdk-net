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

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the GetBot operation. Returns metadata information
    /// for a specific bot. You must provide the bot name and the bot version or alias. <para>
    /// This operation requires permissions for the <c>lex:GetBot</c> action. </para>
    /// </summary>
    [Obsolete("Amazon Lex V1 is deprecated. Use Amazon Lex V2 instead.")]
    public partial class GetBotRequest : AmazonLexModelBuildingServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bot. The name is case sensitive. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property VersionOrAlias. 
        /// <para>
        /// The version or alias of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VersionOrAlias { get; set; }

        /// <summary>
        /// Checks to see if the VersionOrAlias property is set.
        /// </summary>
        internal bool IsSetVersionOrAlias() => this.VersionOrAlias != null;
    }
}
