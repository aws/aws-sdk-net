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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Specify one or more Automated ABR rule types. Note: Force include and Allowed renditions
    /// are mutually exclusive.
    /// </summary>
    public partial class AutomatedAbrRule
    {
        private List<AllowedRenditionSize> _allowedRenditions = AWSConfigs.InitializeCollections ? new List<AllowedRenditionSize>() : null;
        private List<ForceIncludeRenditionSize> _forceIncludeRenditions = AWSConfigs.InitializeCollections ? new List<ForceIncludeRenditionSize>() : null;
        private MinBottomRenditionSize _minBottomRenditionSize;
        private MinTopRenditionSize _minTopRenditionSize;
        private RuleType _type;

        /// <summary>
        /// Gets and sets the property AllowedRenditions. When customer adds the allowed renditions
        /// rule for auto ABR ladder, they are required to add at leat one rendition to allowedRenditions
        /// list
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AllowedRenditionSize> AllowedRenditions
        {
            get { return this._allowedRenditions; }
            set { this._allowedRenditions = value; }
        }

        // Check to see if AllowedRenditions property is set
        internal bool IsSetAllowedRenditions()
        {
            return this._allowedRenditions != null && (this._allowedRenditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ForceIncludeRenditions. When customer adds the force include
        /// renditions rule for auto ABR ladder, they are required to add at leat one rendition
        /// to forceIncludeRenditions list
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ForceIncludeRenditionSize> ForceIncludeRenditions
        {
            get { return this._forceIncludeRenditions; }
            set { this._forceIncludeRenditions = value; }
        }

        // Check to see if ForceIncludeRenditions property is set
        internal bool IsSetForceIncludeRenditions()
        {
            return this._forceIncludeRenditions != null && (this._forceIncludeRenditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MinBottomRenditionSize. Use Min bottom rendition size to
        /// specify a minimum size for the lowest resolution in your ABR stack. * The lowest resolution
        /// in your ABR stack will be equal to or greater than the value that you enter. For example:
        /// If you specify 640x360 the lowest resolution in your ABR stack will be equal to or
        /// greater than to 640x360. * If you specify a Min top rendition size rule, the value
        /// that you specify for Min bottom rendition size must be less than, or equal to, Min
        /// top rendition size.
        /// </summary>
        public MinBottomRenditionSize MinBottomRenditionSize
        {
            get { return this._minBottomRenditionSize; }
            set { this._minBottomRenditionSize = value; }
        }

        // Check to see if MinBottomRenditionSize property is set
        internal bool IsSetMinBottomRenditionSize()
        {
            return this._minBottomRenditionSize != null;
        }

        /// <summary>
        /// Gets and sets the property MinTopRenditionSize. Use Min top rendition size to specify
        /// a minimum size for the highest resolution in your ABR stack. * The highest resolution
        /// in your ABR stack will be equal to or greater than the value that you enter. For example:
        /// If you specify 1280x720 the highest resolution in your ABR stack will be equal to
        /// or greater than 1280x720. * If you specify a value for Max resolution, the value that
        /// you specify for Min top rendition size must be less than, or equal to, Max resolution.
        /// </summary>
        public MinTopRenditionSize MinTopRenditionSize
        {
            get { return this._minTopRenditionSize; }
            set { this._minTopRenditionSize = value; }
        }

        // Check to see if MinTopRenditionSize property is set
        internal bool IsSetMinTopRenditionSize()
        {
            return this._minTopRenditionSize != null;
        }

        /// <summary>
        /// Gets and sets the property Type. Use Min top rendition size to specify a minimum size
        /// for the highest resolution in your ABR stack. * The highest resolution in your ABR
        /// stack will be equal to or greater than the value that you enter. For example: If you
        /// specify 1280x720 the highest resolution in your ABR stack will be equal to or greater
        /// than 1280x720. * If you specify a value for Max resolution, the value that you specify
        /// for Min top rendition size must be less than, or equal to, Max resolution. Use Min
        /// bottom rendition size to specify a minimum size for the lowest resolution in your
        /// ABR stack. * The lowest resolution in your ABR stack will be equal to or greater than
        /// the value that you enter. For example: If you specify 640x360 the lowest resolution
        /// in your ABR stack will be equal to or greater than to 640x360. * If you specify a
        /// Min top rendition size rule, the value that you specify for Min bottom rendition size
        /// must be less than, or equal to, Min top rendition size. Use Force include renditions
        /// to specify one or more resolutions to include your ABR stack. * (Recommended) To optimize
        /// automated ABR, specify as few resolutions as possible. * (Required) The number of
        /// resolutions that you specify must be equal to, or less than, the Max renditions setting.
        /// * If you specify a Min top rendition size rule, specify at least one resolution that
        /// is equal to, or greater than, Min top rendition size. * If you specify a Min bottom
        /// rendition size rule, only specify resolutions that are equal to, or greater than,
        /// Min bottom rendition size. * If you specify a Force include renditions rule, do not
        /// specify a separate rule for Allowed renditions. * Note: The ABR stack may include
        /// other resolutions that you do not specify here, depending on the Max renditions setting.
        /// Use Allowed renditions to specify a list of possible resolutions in your ABR stack.
        /// * (Required) The number of resolutions that you specify must be equal to, or greater
        /// than, the Max renditions setting. * MediaConvert will create an ABR stack exclusively
        /// from the list of resolutions that you specify. * Some resolutions in the Allowed renditions
        /// list may not be included, however you can force a resolution to be included by setting
        /// Required to ENABLED. * You must specify at least one resolution that is greater than
        /// or equal to any resolutions that you specify in Min top rendition size or Min bottom
        /// rendition size. * If you specify Allowed renditions, you must not specify a separate
        /// rule for Force include renditions.
        /// </summary>
        public RuleType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}