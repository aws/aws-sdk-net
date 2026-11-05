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

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// This is the response object from the ListWorkersWithQualificationType operation.
    /// </summary>
    public partial class ListWorkersWithQualificationTypeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property NumResults. 
        /// <para>
        ///  The number of Qualifications on this page in the filtered results list, equivalent
        /// to the number of Qualifications being returned by this call.
        /// </para>
        /// </summary>
        public int? NumResults { get; set; }

        /// <summary>
        /// Checks to see if the NumResults property is set.
        /// </summary>
        internal bool IsSetNumResults() => this.NumResults.HasValue;

        /// <summary>
        /// Gets and sets the property Qualifications. 
        /// <para>
        ///  The list of Qualification elements returned by this call. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Qualification> Qualifications { get; set; } = AWSConfigs.InitializeCollections ? new List<Qualification>() : null;

        /// <summary>
        /// Checks to see if the Qualifications property is set.
        /// </summary>
        internal bool IsSetQualifications() => this.Qualifications != null && (this.Qualifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
