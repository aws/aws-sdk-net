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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Summary information for the retriever used for your Amazon Q Business application.
    /// </summary>
    public partial class Retriever
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application using the retriever.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of your retriever.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property RetrieverId. 
        /// <para>
        /// The identifier of the retriever used by your Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string RetrieverId { get; set; }

        /// <summary>
        /// Checks to see if the RetrieverId property is set.
        /// </summary>
        internal bool IsSetRetrieverId() => this.RetrieverId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of your retriever.
        /// </para>
        /// </summary>
        public RetrieverStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of your retriever.
        /// </para>
        /// </summary>
        public RetrieverType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
