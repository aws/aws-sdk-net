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
    /// Container for the parameters to the PutWorkflowRunProperties operation.
    /// Puts the specified workflow run properties for the given workflow run. If a property
    /// already exists for the specified run, then it overrides the value otherwise adds the
    /// property to existing properties.
    /// </summary>
    public partial class PutWorkflowRunPropertiesRequest : AmazonGlueRequest
    {
        private string _name;
        private string _runId;
        private Dictionary<string, string> _runProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the workflow which was run.
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
        /// Gets and sets the property RunId. 
        /// <para>
        /// The ID of the workflow run for which the run properties should be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

        /// <summary>
        /// Gets and sets the property RunProperties. 
        /// <para>
        /// The properties to put for the specified run.
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
        [AWSProperty(Required=true)]
        public Dictionary<string, string> RunProperties
        {
            get { return this._runProperties; }
            set { this._runProperties = value; }
        }

        // Check to see if RunProperties property is set
        internal bool IsSetRunProperties()
        {
            return this._runProperties != null && (this._runProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}