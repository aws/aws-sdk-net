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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
    /// Container for the parameters to the DeleteExperimentDefinition operation.
    /// Deletes an experiment definition. You can archive the definition to hide it from the
    /// active list while preserving it for future reference, or permanently delete it along
    /// with all associated run history.
    /// </summary>
    public partial class DeleteExperimentDefinitionRequest : AmazonAppConfigRequest
    {
        private string _applicationIdentifier;
        private DeleteType _deleteType;
        private string _experimentDefinitionIdentifier;

        /// <summary>
        /// Gets and sets the property ApplicationIdentifier. 
        /// <para>
        /// The application ID or name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ApplicationIdentifier
        {
            get { return this._applicationIdentifier; }
            set { this._applicationIdentifier = value; }
        }

        // Check to see if ApplicationIdentifier property is set
        internal bool IsSetApplicationIdentifier()
        {
            return this._applicationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteType. 
        /// <para>
        /// The type of deletion to perform. Valid values include archive (hide but preserve)
        /// and permanent (delete permanently).
        /// </para>
        /// </summary>
        public DeleteType DeleteType
        {
            get { return this._deleteType; }
            set { this._deleteType = value; }
        }

        // Check to see if DeleteType property is set
        internal bool IsSetDeleteType()
        {
            return this._deleteType != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentDefinitionIdentifier. 
        /// <para>
        /// The experiment definition ID or name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ExperimentDefinitionIdentifier
        {
            get { return this._experimentDefinitionIdentifier; }
            set { this._experimentDefinitionIdentifier = value; }
        }

        // Check to see if ExperimentDefinitionIdentifier property is set
        internal bool IsSetExperimentDefinitionIdentifier()
        {
            return this._experimentDefinitionIdentifier != null;
        }

    }
}