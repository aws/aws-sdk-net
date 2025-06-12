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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// Summary info for an adapter version. Contains information on the AdapterId, AdapterVersion,
    /// CreationTime, FeatureTypes, and Status.
    /// </summary>
    public partial class AdapterVersionOverview
    {
        private string _adapterId;
        private string _adapterVersion;
        private DateTime? _creationTime;
        private List<string> _featureTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AdapterVersionStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property AdapterId. 
        /// <para>
        /// A unique identifier for the adapter associated with a given adapter version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=1011)]
        public string AdapterId
        {
            get { return this._adapterId; }
            set { this._adapterId = value; }
        }

        // Check to see if AdapterId property is set
        internal bool IsSetAdapterId()
        {
            return this._adapterId != null;
        }

        /// <summary>
        /// Gets and sets the property AdapterVersion. 
        /// <para>
        /// An identified for a given adapter version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AdapterVersion
        {
            get { return this._adapterVersion; }
            set { this._adapterVersion = value; }
        }

        // Check to see if AdapterVersion property is set
        internal bool IsSetAdapterVersion()
        {
            return this._adapterVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a given adapter version was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FeatureTypes. 
        /// <para>
        /// The feature types that the adapter version is operating on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FeatureTypes
        {
            get { return this._featureTypes; }
            set { this._featureTypes = value; }
        }

        // Check to see if FeatureTypes property is set
        internal bool IsSetFeatureTypes()
        {
            return this._featureTypes != null && (this._featureTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Contains information on the status of a given adapter version.
        /// </para>
        /// </summary>
        public AdapterVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message explaining the status of a given adapter vesion.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}