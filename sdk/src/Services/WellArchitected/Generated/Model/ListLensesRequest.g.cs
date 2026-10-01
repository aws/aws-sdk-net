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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the ListLenses operation. List the available lenses.
    /// </summary>
    public partial class ListLensesRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property LensName.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string LensName { get; set; }

        /// <summary>
        /// Checks to see if the LensName property is set.
        /// </summary>
        internal bool IsSetLensName() => this.LensName != null;

        /// <summary>
        /// Gets and sets the property LensStatus. 
        /// <para>
        /// The status of lenses to be returned.
        /// </para>
        /// </summary>
        public LensStatusType LensStatus { get; set; }

        /// <summary>
        /// Checks to see if the LensStatus property is set.
        /// </summary>
        internal bool IsSetLensStatus() => this.LensStatus != null;

        /// <summary>
        /// Gets and sets the property LensType. 
        /// <para>
        /// The type of lenses to be returned.
        /// </para>
        /// </summary>
        public LensType LensType { get; set; }

        /// <summary>
        /// Checks to see if the LensType property is set.
        /// </summary>
        internal bool IsSetLensType() => this.LensType != null;

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
