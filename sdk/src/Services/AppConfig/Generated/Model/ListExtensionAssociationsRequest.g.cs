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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the ListExtensionAssociations operation. Lists all
    /// AppConfig extension associations in the account. For more information about extensions
    /// and associations, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
    /// workflows</a> in the <i>AppConfig User Guide</i>.
    /// </summary>
    public partial class ListExtensionAssociationsRequest : AmazonAppConfigRequest
    {
        /// <summary>
        /// Gets and sets the property ExtensionIdentifier. 
        /// <para>
        /// The name, the ID, or the Amazon Resource Name (ARN) of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ExtensionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionIdentifier property is set.
        /// </summary>
        internal bool IsSetExtensionIdentifier() => this.ExtensionIdentifier != null;

        /// <summary>
        /// Gets and sets the property ExtensionVersionNumber. 
        /// <para>
        /// The version number for the extension defined in the association.
        /// </para>
        /// </summary>
        public int? ExtensionVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionVersionNumber property is set.
        /// </summary>
        internal bool IsSetExtensionVersionNumber() => this.ExtensionVersionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to start the list. Use this token to get the next set of results or pass null
        /// to get the first set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The ARN of an application, configuration profile, or environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;
    }
}
