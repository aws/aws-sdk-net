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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStreamProcessor operation.
    /// Allows you to update a stream processor. You can change some settings and regions
    /// of interest and delete certain parameters.
    /// </summary>
    public partial class UpdateStreamProcessorRequest : AmazonRekognitionRequest
    {
        private StreamProcessorDataSharingPreference _dataSharingPreferenceForUpdate;
        private string _name;
        private List<string> _parametersToDelete = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<RegionOfInterest> _regionsOfInterestForUpdate = AWSConfigs.InitializeCollections ? new List<RegionOfInterest>() : null;
        private StreamProcessorSettingsForUpdate _settingsForUpdate;

        /// <summary>
        /// Gets and sets the property DataSharingPreferenceForUpdate. 
        /// <para>
        ///  Shows whether you are sharing data with Rekognition to improve model performance.
        /// You can choose this option at the account level or on a per-stream basis. Note that
        /// if you opt out at the account level this setting is ignored on individual streams.
        /// 
        /// </para>
        /// </summary>
        public StreamProcessorDataSharingPreference DataSharingPreferenceForUpdate
        {
            get { return this._dataSharingPreferenceForUpdate; }
            set { this._dataSharingPreferenceForUpdate = value; }
        }

        // Check to see if DataSharingPreferenceForUpdate property is set
        internal bool IsSetDataSharingPreferenceForUpdate()
        {
            return this._dataSharingPreferenceForUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  Name of the stream processor that you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property ParametersToDelete. 
        /// <para>
        ///  A list of parameters you want to delete from the stream processor. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ParametersToDelete
        {
            get { return this._parametersToDelete; }
            set { this._parametersToDelete = value; }
        }

        // Check to see if ParametersToDelete property is set
        internal bool IsSetParametersToDelete()
        {
            return this._parametersToDelete != null && (this._parametersToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegionsOfInterestForUpdate. 
        /// <para>
        ///  Specifies locations in the frames where Amazon Rekognition checks for objects or
        /// people. This is an optional parameter for label detection stream processors. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<RegionOfInterest> RegionsOfInterestForUpdate
        {
            get { return this._regionsOfInterestForUpdate; }
            set { this._regionsOfInterestForUpdate = value; }
        }

        // Check to see if RegionsOfInterestForUpdate property is set
        internal bool IsSetRegionsOfInterestForUpdate()
        {
            return this._regionsOfInterestForUpdate != null && (this._regionsOfInterestForUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SettingsForUpdate. 
        /// <para>
        ///  The stream processor settings that you want to update. Label detection settings can
        /// be updated to detect different labels with a different minimum confidence. 
        /// </para>
        /// </summary>
        public StreamProcessorSettingsForUpdate SettingsForUpdate
        {
            get { return this._settingsForUpdate; }
            set { this._settingsForUpdate = value; }
        }

        // Check to see if SettingsForUpdate property is set
        internal bool IsSetSettingsForUpdate()
        {
            return this._settingsForUpdate != null;
        }

    }
}