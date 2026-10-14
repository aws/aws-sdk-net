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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStreamProcessor operation. <important> <para>
    /// Service availability notice: Streaming Video and Bulk Image Analysis is no longer
    /// available to new customers. For more information, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/rekognition-availability-changes.html">Rekognition
    /// feature availability changes</a>. </para> <para> <b>This change does not impact the
    /// availability of other Amazon Rekognition features.</b> </para> </important> <para>
    /// Allows you to update a stream processor. You can change some settings and regions
    /// of interest and delete certain parameters. </para>
    /// </summary>
    public partial class UpdateStreamProcessorRequest : AmazonRekognitionRequest
    {
        /// <summary>
        /// Gets and sets the property DataSharingPreferenceForUpdate. 
        /// <para>
        ///  Shows whether you are sharing data with Rekognition to improve model performance.
        /// You can choose this option at the account level or on a per-stream basis. Note that
        /// if you opt out at the account level this setting is ignored on individual streams.
        /// 
        /// </para>
        /// </summary>
        public StreamProcessorDataSharingPreference DataSharingPreferenceForUpdate { get; set; }

        /// <summary>
        /// Checks to see if the DataSharingPreferenceForUpdate property is set.
        /// </summary>
        internal bool IsSetDataSharingPreferenceForUpdate() => this.DataSharingPreferenceForUpdate != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  Name of the stream processor that you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParametersToDelete. 
        /// <para>
        ///  A list of parameters you want to delete from the stream processor. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ParametersToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ParametersToDelete property is set.
        /// </summary>
        internal bool IsSetParametersToDelete() => this.ParametersToDelete != null && (this.ParametersToDelete.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegionsOfInterestForUpdate. 
        /// <para>
        ///  Specifies locations in the frames where Amazon Rekognition checks for objects or
        /// people. This is an optional parameter for label detection stream processors. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<RegionOfInterest> RegionsOfInterestForUpdate { get; set; } = AWSConfigs.InitializeCollections ? new List<RegionOfInterest>() : null;

        /// <summary>
        /// Checks to see if the RegionsOfInterestForUpdate property is set.
        /// </summary>
        internal bool IsSetRegionsOfInterestForUpdate() => this.RegionsOfInterestForUpdate != null && (this.RegionsOfInterestForUpdate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SettingsForUpdate. 
        /// <para>
        ///  The stream processor settings that you want to update. Label detection settings can
        /// be updated to detect different labels with a different minimum confidence. 
        /// </para>
        /// </summary>
        public StreamProcessorSettingsForUpdate SettingsForUpdate { get; set; }

        /// <summary>
        /// Checks to see if the SettingsForUpdate property is set.
        /// </summary>
        internal bool IsSetSettingsForUpdate() => this.SettingsForUpdate != null;
    }
}
