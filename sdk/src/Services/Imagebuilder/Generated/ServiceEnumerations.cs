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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Imagebuilder
{

    /// <summary>
    /// Constants used for properties of type BuildType.
    /// </summary>
    public class BuildType : ConstantClass
    {

        /// <summary>
        /// Constant IMPORT for BuildType
        /// </summary>
        public static readonly BuildType IMPORT = new BuildType("IMPORT");
        /// <summary>
        /// Constant SCHEDULED for BuildType
        /// </summary>
        public static readonly BuildType SCHEDULED = new BuildType("SCHEDULED");
        /// <summary>
        /// Constant USER_INITIATED for BuildType
        /// </summary>
        public static readonly BuildType USER_INITIATED = new BuildType("USER_INITIATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BuildType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BuildType FindValue(string value)
        {
            return FindValue<BuildType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BuildType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComponentFormat.
    /// </summary>
    public class ComponentFormat : ConstantClass
    {

        /// <summary>
        /// Constant SHELL for ComponentFormat
        /// </summary>
        public static readonly ComponentFormat SHELL = new ComponentFormat("SHELL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComponentFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComponentFormat FindValue(string value)
        {
            return FindValue<ComponentFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComponentFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComponentStatus.
    /// </summary>
    public class ComponentStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEPRECATED for ComponentStatus
        /// </summary>
        public static readonly ComponentStatus DEPRECATED = new ComponentStatus("DEPRECATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComponentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComponentStatus FindValue(string value)
        {
            return FindValue<ComponentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComponentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComponentType.
    /// </summary>
    public class ComponentType : ConstantClass
    {

        /// <summary>
        /// Constant BUILD for ComponentType
        /// </summary>
        public static readonly ComponentType BUILD = new ComponentType("BUILD");
        /// <summary>
        /// Constant TEST for ComponentType
        /// </summary>
        public static readonly ComponentType TEST = new ComponentType("TEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComponentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComponentType FindValue(string value)
        {
            return FindValue<ComponentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComponentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerRepositoryService.
    /// </summary>
    public class ContainerRepositoryService : ConstantClass
    {

        /// <summary>
        /// Constant ECR for ContainerRepositoryService
        /// </summary>
        public static readonly ContainerRepositoryService ECR = new ContainerRepositoryService("ECR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerRepositoryService(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerRepositoryService FindValue(string value)
        {
            return FindValue<ContainerRepositoryService>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerRepositoryService(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerType.
    /// </summary>
    public class ContainerType : ConstantClass
    {

        /// <summary>
        /// Constant DOCKER for ContainerType
        /// </summary>
        public static readonly ContainerType DOCKER = new ContainerType("DOCKER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerType FindValue(string value)
        {
            return FindValue<ContainerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiskImageFormat.
    /// </summary>
    public class DiskImageFormat : ConstantClass
    {

        /// <summary>
        /// Constant RAW for DiskImageFormat
        /// </summary>
        public static readonly DiskImageFormat RAW = new DiskImageFormat("RAW");
        /// <summary>
        /// Constant VHD for DiskImageFormat
        /// </summary>
        public static readonly DiskImageFormat VHD = new DiskImageFormat("VHD");
        /// <summary>
        /// Constant VMDK for DiskImageFormat
        /// </summary>
        public static readonly DiskImageFormat VMDK = new DiskImageFormat("VMDK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiskImageFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiskImageFormat FindValue(string value)
        {
            return FindValue<DiskImageFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiskImageFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EbsVolumeType.
    /// </summary>
    public class EbsVolumeType : ConstantClass
    {

        /// <summary>
        /// Constant Gp2 for EbsVolumeType
        /// </summary>
        public static readonly EbsVolumeType Gp2 = new EbsVolumeType("gp2");
        /// <summary>
        /// Constant Gp3 for EbsVolumeType
        /// </summary>
        public static readonly EbsVolumeType Gp3 = new EbsVolumeType("gp3");
        /// <summary>
        /// Constant Io1 for EbsVolumeType
        /// </summary>
        public static readonly EbsVolumeType Io1 = new EbsVolumeType("io1");
        /// <summary>
        /// Constant Io2 for EbsVolumeType
        /// </summary>
        public static readonly EbsVolumeType Io2 = new EbsVolumeType("io2");
        /// <summary>
        /// Constant Sc1 for EbsVolumeType
        /// </summary>
        public static readonly EbsVolumeType Sc1 = new EbsVolumeType("sc1");
        /// <summary>
        /// Constant St1 for EbsVolumeType
        /// </summary>
        public static readonly EbsVolumeType St1 = new EbsVolumeType("st1");
        /// <summary>
        /// Constant Standard for EbsVolumeType
        /// </summary>
        public static readonly EbsVolumeType Standard = new EbsVolumeType("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EbsVolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EbsVolumeType FindValue(string value)
        {
            return FindValue<EbsVolumeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EbsVolumeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageSource.
    /// </summary>
    public class ImageSource : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_MANAGED for ImageSource
        /// </summary>
        public static readonly ImageSource AMAZON_MANAGED = new ImageSource("AMAZON_MANAGED");
        /// <summary>
        /// Constant AWS_MARKETPLACE for ImageSource
        /// </summary>
        public static readonly ImageSource AWS_MARKETPLACE = new ImageSource("AWS_MARKETPLACE");
        /// <summary>
        /// Constant CUSTOM for ImageSource
        /// </summary>
        public static readonly ImageSource CUSTOM = new ImageSource("CUSTOM");
        /// <summary>
        /// Constant IMPORTED for ImageSource
        /// </summary>
        public static readonly ImageSource IMPORTED = new ImageSource("IMPORTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageSource FindValue(string value)
        {
            return FindValue<ImageSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageStatus.
    /// </summary>
    public class ImageStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ImageStatus
        /// </summary>
        public static readonly ImageStatus AVAILABLE = new ImageStatus("AVAILABLE");
        /// <summary>
        /// Constant BUILDING for ImageStatus
        /// </summary>
        public static readonly ImageStatus BUILDING = new ImageStatus("BUILDING");
        /// <summary>
        /// Constant CANCELLED for ImageStatus
        /// </summary>
        public static readonly ImageStatus CANCELLED = new ImageStatus("CANCELLED");
        /// <summary>
        /// Constant CREATING for ImageStatus
        /// </summary>
        public static readonly ImageStatus CREATING = new ImageStatus("CREATING");
        /// <summary>
        /// Constant DELETED for ImageStatus
        /// </summary>
        public static readonly ImageStatus DELETED = new ImageStatus("DELETED");
        /// <summary>
        /// Constant DEPRECATED for ImageStatus
        /// </summary>
        public static readonly ImageStatus DEPRECATED = new ImageStatus("DEPRECATED");
        /// <summary>
        /// Constant DISTRIBUTING for ImageStatus
        /// </summary>
        public static readonly ImageStatus DISTRIBUTING = new ImageStatus("DISTRIBUTING");
        /// <summary>
        /// Constant FAILED for ImageStatus
        /// </summary>
        public static readonly ImageStatus FAILED = new ImageStatus("FAILED");
        /// <summary>
        /// Constant INTEGRATING for ImageStatus
        /// </summary>
        public static readonly ImageStatus INTEGRATING = new ImageStatus("INTEGRATING");
        /// <summary>
        /// Constant PENDING for ImageStatus
        /// </summary>
        public static readonly ImageStatus PENDING = new ImageStatus("PENDING");
        /// <summary>
        /// Constant TESTING for ImageStatus
        /// </summary>
        public static readonly ImageStatus TESTING = new ImageStatus("TESTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageStatus FindValue(string value)
        {
            return FindValue<ImageStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageType.
    /// </summary>
    public class ImageType : ConstantClass
    {

        /// <summary>
        /// Constant AMI for ImageType
        /// </summary>
        public static readonly ImageType AMI = new ImageType("AMI");
        /// <summary>
        /// Constant DOCKER for ImageType
        /// </summary>
        public static readonly ImageType DOCKER = new ImageType("DOCKER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageType FindValue(string value)
        {
            return FindValue<ImageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ownership.
    /// </summary>
    public class Ownership : ConstantClass
    {

        /// <summary>
        /// Constant Amazon for Ownership
        /// </summary>
        public static readonly Ownership Amazon = new Ownership("Amazon");
        /// <summary>
        /// Constant Self for Ownership
        /// </summary>
        public static readonly Ownership Self = new Ownership("Self");
        /// <summary>
        /// Constant Shared for Ownership
        /// </summary>
        public static readonly Ownership Shared = new Ownership("Shared");
        /// <summary>
        /// Constant ThirdParty for Ownership
        /// </summary>
        public static readonly Ownership ThirdParty = new Ownership("ThirdParty");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ownership(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ownership FindValue(string value)
        {
            return FindValue<Ownership>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ownership(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipelineExecutionStartCondition.
    /// </summary>
    public class PipelineExecutionStartCondition : ConstantClass
    {

        /// <summary>
        /// Constant EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE for PipelineExecutionStartCondition
        /// </summary>
        public static readonly PipelineExecutionStartCondition EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE = new PipelineExecutionStartCondition("EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE");
        /// <summary>
        /// Constant EXPRESSION_MATCH_ONLY for PipelineExecutionStartCondition
        /// </summary>
        public static readonly PipelineExecutionStartCondition EXPRESSION_MATCH_ONLY = new PipelineExecutionStartCondition("EXPRESSION_MATCH_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipelineExecutionStartCondition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipelineExecutionStartCondition FindValue(string value)
        {
            return FindValue<PipelineExecutionStartCondition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipelineExecutionStartCondition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipelineStatus.
    /// </summary>
    public class PipelineStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for PipelineStatus
        /// </summary>
        public static readonly PipelineStatus DISABLED = new PipelineStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for PipelineStatus
        /// </summary>
        public static readonly PipelineStatus ENABLED = new PipelineStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipelineStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipelineStatus FindValue(string value)
        {
            return FindValue<PipelineStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipelineStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Platform.
    /// </summary>
    public class Platform : ConstantClass
    {

        /// <summary>
        /// Constant Linux for Platform
        /// </summary>
        public static readonly Platform Linux = new Platform("Linux");
        /// <summary>
        /// Constant Windows for Platform
        /// </summary>
        public static readonly Platform Windows = new Platform("Windows");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Platform(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Platform FindValue(string value)
        {
            return FindValue<Platform>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Platform(string value)
        {
            return FindValue(value);
        }
    }

}