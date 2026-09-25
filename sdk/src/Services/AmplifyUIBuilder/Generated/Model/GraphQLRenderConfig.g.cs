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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the GraphQL configuration for an API for a code generation job.
    /// </summary>
    public partial class GraphQLRenderConfig
    {
        /// <summary>
        /// Gets and sets the property FragmentsFilePath. 
        /// <para>
        /// The path to the GraphQL fragments file, relative to the component output directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FragmentsFilePath { get; set; }

        /// <summary>
        /// Checks to see if the FragmentsFilePath property is set.
        /// </summary>
        internal bool IsSetFragmentsFilePath() => this.FragmentsFilePath != null;

        /// <summary>
        /// Gets and sets the property MutationsFilePath. 
        /// <para>
        /// The path to the GraphQL mutations file, relative to the component output directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MutationsFilePath { get; set; }

        /// <summary>
        /// Checks to see if the MutationsFilePath property is set.
        /// </summary>
        internal bool IsSetMutationsFilePath() => this.MutationsFilePath != null;

        /// <summary>
        /// Gets and sets the property QueriesFilePath. 
        /// <para>
        /// The path to the GraphQL queries file, relative to the component output directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueriesFilePath { get; set; }

        /// <summary>
        /// Checks to see if the QueriesFilePath property is set.
        /// </summary>
        internal bool IsSetQueriesFilePath() => this.QueriesFilePath != null;

        /// <summary>
        /// Gets and sets the property SubscriptionsFilePath. 
        /// <para>
        /// The path to the GraphQL subscriptions file, relative to the component output directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubscriptionsFilePath { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionsFilePath property is set.
        /// </summary>
        internal bool IsSetSubscriptionsFilePath() => this.SubscriptionsFilePath != null;

        /// <summary>
        /// Gets and sets the property TypesFilePath. 
        /// <para>
        /// The path to the GraphQL types file, relative to the component output directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TypesFilePath { get; set; }

        /// <summary>
        /// Checks to see if the TypesFilePath property is set.
        /// </summary>
        internal bool IsSetTypesFilePath() => this.TypesFilePath != null;
    }
}
