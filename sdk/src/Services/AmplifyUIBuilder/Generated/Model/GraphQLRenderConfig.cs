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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
        private string _fragmentsFilePath;
        private string _mutationsFilePath;
        private string _queriesFilePath;
        private string _subscriptionsFilePath;
        private string _typesFilePath;

        /// <summary>
        /// Gets and sets the property FragmentsFilePath. 
        /// <para>
        /// The path to the GraphQL fragments file, relative to the component output directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FragmentsFilePath
        {
            get { return this._fragmentsFilePath; }
            set { this._fragmentsFilePath = value; }
        }

        // Check to see if FragmentsFilePath property is set
        internal bool IsSetFragmentsFilePath()
        {
            return this._fragmentsFilePath != null;
        }

        /// <summary>
        /// Gets and sets the property MutationsFilePath. 
        /// <para>
        /// The path to the GraphQL mutations file, relative to the component output directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MutationsFilePath
        {
            get { return this._mutationsFilePath; }
            set { this._mutationsFilePath = value; }
        }

        // Check to see if MutationsFilePath property is set
        internal bool IsSetMutationsFilePath()
        {
            return this._mutationsFilePath != null;
        }

        /// <summary>
        /// Gets and sets the property QueriesFilePath. 
        /// <para>
        /// The path to the GraphQL queries file, relative to the component output directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueriesFilePath
        {
            get { return this._queriesFilePath; }
            set { this._queriesFilePath = value; }
        }

        // Check to see if QueriesFilePath property is set
        internal bool IsSetQueriesFilePath()
        {
            return this._queriesFilePath != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionsFilePath. 
        /// <para>
        /// The path to the GraphQL subscriptions file, relative to the component output directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscriptionsFilePath
        {
            get { return this._subscriptionsFilePath; }
            set { this._subscriptionsFilePath = value; }
        }

        // Check to see if SubscriptionsFilePath property is set
        internal bool IsSetSubscriptionsFilePath()
        {
            return this._subscriptionsFilePath != null;
        }

        /// <summary>
        /// Gets and sets the property TypesFilePath. 
        /// <para>
        /// The path to the GraphQL types file, relative to the component output directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TypesFilePath
        {
            get { return this._typesFilePath; }
            set { this._typesFilePath = value; }
        }

        // Check to see if TypesFilePath property is set
        internal bool IsSetTypesFilePath()
        {
            return this._typesFilePath != null;
        }

    }
}