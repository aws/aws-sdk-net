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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWorkflow operation.
    /// Creates a new workflow.
    /// </summary>
    public partial class CreateWorkflowRequest : AmazonGlueRequest
    {
        private Dictionary<string, string> _defaultRunProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _description;
        private int? _maxConcurrentRuns;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DefaultRunProperties. 
        /// <para>
        /// A collection of properties to be used as part of each execution of the workflow.
        /// </para>
        ///  
        /// <para>
        /// Run properties may be logged. Do not pass plaintext secrets as properties. Retrieve
        /// secrets from a Glue Connection, Amazon Web Services Secrets Manager or other secret
        /// management mechanism if you intend to use them within the workflow run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DefaultRunProperties
        {
            get { return this._defaultRunProperties; }
            set { this._defaultRunProperties = value; }
        }

        // Check to see if DefaultRunProperties property is set
        internal bool IsSetDefaultRunProperties()
        {
            return this._defaultRunProperties != null && (this._defaultRunProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Max=120000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrentRuns. 
        /// <para>
        /// You can use this parameter to prevent unwanted multiple updates to data, to control
        /// costs, or in some cases, to prevent exceeding the maximum number of concurrent runs
        /// of any of the component jobs. If you leave this parameter blank, there is no limit
        /// to the number of concurrent workflow runs.
        /// </para>
        /// </summary>
        public int? MaxConcurrentRuns
        {
            get { return this._maxConcurrentRuns; }
            set { this._maxConcurrentRuns = value; }
        }

        // Check to see if MaxConcurrentRuns property is set
        internal bool IsSetMaxConcurrentRuns()
        {
            return this._maxConcurrentRuns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to be assigned to the workflow. It should be unique within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be used with this workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}