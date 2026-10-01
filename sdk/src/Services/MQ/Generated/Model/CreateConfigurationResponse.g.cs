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

namespace Amazon.MQ.Model
{
    /// <summary>
    /// This is the response object from the CreateConfiguration operation.
    /// </summary>
    public partial class CreateConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Required. The Amazon Resource Name (ARN) of the configuration.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AuthenticationStrategy. 
        /// <para>
        /// Optional. The authentication strategy associated with the configuration. The default
        /// is SIMPLE.
        /// </para>
        /// </summary>
        public AuthenticationStrategy AuthenticationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationStrategy property is set.
        /// </summary>
        internal bool IsSetAuthenticationStrategy() => this.AuthenticationStrategy != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// Required. The date and time of the configuration.
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Required. The unique ID that Amazon MQ generates for the configuration.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LatestRevision. 
        /// <para>
        /// The latest revision of the configuration.
        /// </para>
        /// </summary>
        public ConfigurationRevision LatestRevision { get; set; }

        /// <summary>
        /// Checks to see if the LatestRevision property is set.
        /// </summary>
        internal bool IsSetLatestRevision() => this.LatestRevision != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Required. The name of the configuration. This value can contain only alphanumeric
        /// characters, dashes, periods, underscores, and tildes (- . _ ~). This value must be
        /// 1-150 characters long.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
