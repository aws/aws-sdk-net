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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// This is the response object from the DescribeEntity operation.
    /// </summary>
    public partial class DescribeEntityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// This stringified JSON object includes the details of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 16384)]
        public string Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property DetailsDocument. 
        /// <para>
        /// The JSON value of the details specific to the entity.
        /// </para>
        ///  
        /// <para>
        /// To download "DetailsDocument" shapes, see the <a href="https://github.com/awslabs/aws-marketplace-catalog-api-shapes-for-python">Python</a>
        /// and <a href="https://github.com/awslabs/aws-marketplace-catalog-api-shapes-for-java/tree/main">Java</a>
        /// shapes on GitHub.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document DetailsDocument { get; set; }

        /// <summary>
        /// Checks to see if the DetailsDocument property is set.
        /// </summary>
        internal bool IsSetDetailsDocument() => !this.DetailsDocument.IsNull();

        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        /// The ARN associated to the unique identifier for the entity referenced in this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EntityArn { get; set; }

        /// <summary>
        /// Checks to see if the EntityArn property is set.
        /// </summary>
        internal bool IsSetEntityArn() => this.EntityArn != null;

        /// <summary>
        /// Gets and sets the property EntityIdentifier. 
        /// <para>
        /// The identifier of the entity, in the format of <c>EntityId@RevisionId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EntityIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EntityIdentifier property is set.
        /// </summary>
        internal bool IsSetEntityIdentifier() => this.EntityIdentifier != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The named type of the entity, in the format of <c>EntityType@Version</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The last modified date of the entity, in ISO 8601 format (2018-02-27T13:45:22Z).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;
    }
}
