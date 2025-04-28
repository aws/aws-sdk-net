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
        /// Constant IMPORT_ISO for BuildType
        /// </summary>
        public static readonly BuildType IMPORT_ISO = new BuildType("IMPORT_ISO");
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
        /// Constant ACTIVE for ComponentStatus
        /// </summary>
        public static readonly ComponentStatus ACTIVE = new ComponentStatus("ACTIVE");
        /// <summary>
        /// Constant DEPRECATED for ComponentStatus
        /// </summary>
        public static readonly ComponentStatus DEPRECATED = new ComponentStatus("DEPRECATED");
        /// <summary>
        /// Constant DISABLED for ComponentStatus
        /// </summary>
        public static readonly ComponentStatus DISABLED = new ComponentStatus("DISABLED");

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
    /// Constants used for properties of type ImageScanStatus.
    /// </summary>
    public class ImageScanStatus : ConstantClass
    {

        /// <summary>
        /// Constant ABANDONED for ImageScanStatus
        /// </summary>
        public static readonly ImageScanStatus ABANDONED = new ImageScanStatus("ABANDONED");
        /// <summary>
        /// Constant COLLECTING for ImageScanStatus
        /// </summary>
        public static readonly ImageScanStatus COLLECTING = new ImageScanStatus("COLLECTING");
        /// <summary>
        /// Constant COMPLETED for ImageScanStatus
        /// </summary>
        public static readonly ImageScanStatus COMPLETED = new ImageScanStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ImageScanStatus
        /// </summary>
        public static readonly ImageScanStatus FAILED = new ImageScanStatus("FAILED");
        /// <summary>
        /// Constant PENDING for ImageScanStatus
        /// </summary>
        public static readonly ImageScanStatus PENDING = new ImageScanStatus("PENDING");
        /// <summary>
        /// Constant SCANNING for ImageScanStatus
        /// </summary>
        public static readonly ImageScanStatus SCANNING = new ImageScanStatus("SCANNING");
        /// <summary>
        /// Constant TIMED_OUT for ImageScanStatus
        /// </summary>
        public static readonly ImageScanStatus TIMED_OUT = new ImageScanStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageScanStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageScanStatus FindValue(string value)
        {
            return FindValue<ImageScanStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageScanStatus(string value)
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
        /// Constant DISABLED for ImageStatus
        /// </summary>
        public static readonly ImageStatus DISABLED = new ImageStatus("DISABLED");
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
    /// Constants used for properties of type LifecycleExecutionResourceActionName.
    /// </summary>
    public class LifecycleExecutionResourceActionName : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for LifecycleExecutionResourceActionName
        /// </summary>
        public static readonly LifecycleExecutionResourceActionName AVAILABLE = new LifecycleExecutionResourceActionName("AVAILABLE");
        /// <summary>
        /// Constant DELETE for LifecycleExecutionResourceActionName
        /// </summary>
        public static readonly LifecycleExecutionResourceActionName DELETE = new LifecycleExecutionResourceActionName("DELETE");
        /// <summary>
        /// Constant DEPRECATE for LifecycleExecutionResourceActionName
        /// </summary>
        public static readonly LifecycleExecutionResourceActionName DEPRECATE = new LifecycleExecutionResourceActionName("DEPRECATE");
        /// <summary>
        /// Constant DISABLE for LifecycleExecutionResourceActionName
        /// </summary>
        public static readonly LifecycleExecutionResourceActionName DISABLE = new LifecycleExecutionResourceActionName("DISABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecycleExecutionResourceActionName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecycleExecutionResourceActionName FindValue(string value)
        {
            return FindValue<LifecycleExecutionResourceActionName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecycleExecutionResourceActionName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecycleExecutionResourceStatus.
    /// </summary>
    public class LifecycleExecutionResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for LifecycleExecutionResourceStatus
        /// </summary>
        public static readonly LifecycleExecutionResourceStatus FAILED = new LifecycleExecutionResourceStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for LifecycleExecutionResourceStatus
        /// </summary>
        public static readonly LifecycleExecutionResourceStatus IN_PROGRESS = new LifecycleExecutionResourceStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SKIPPED for LifecycleExecutionResourceStatus
        /// </summary>
        public static readonly LifecycleExecutionResourceStatus SKIPPED = new LifecycleExecutionResourceStatus("SKIPPED");
        /// <summary>
        /// Constant SUCCESS for LifecycleExecutionResourceStatus
        /// </summary>
        public static readonly LifecycleExecutionResourceStatus SUCCESS = new LifecycleExecutionResourceStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecycleExecutionResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecycleExecutionResourceStatus FindValue(string value)
        {
            return FindValue<LifecycleExecutionResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecycleExecutionResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecycleExecutionStatus.
    /// </summary>
    public class LifecycleExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for LifecycleExecutionStatus
        /// </summary>
        public static readonly LifecycleExecutionStatus CANCELLED = new LifecycleExecutionStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for LifecycleExecutionStatus
        /// </summary>
        public static readonly LifecycleExecutionStatus CANCELLING = new LifecycleExecutionStatus("CANCELLING");
        /// <summary>
        /// Constant FAILED for LifecycleExecutionStatus
        /// </summary>
        public static readonly LifecycleExecutionStatus FAILED = new LifecycleExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for LifecycleExecutionStatus
        /// </summary>
        public static readonly LifecycleExecutionStatus IN_PROGRESS = new LifecycleExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for LifecycleExecutionStatus
        /// </summary>
        public static readonly LifecycleExecutionStatus PENDING = new LifecycleExecutionStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for LifecycleExecutionStatus
        /// </summary>
        public static readonly LifecycleExecutionStatus SUCCESS = new LifecycleExecutionStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecycleExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecycleExecutionStatus FindValue(string value)
        {
            return FindValue<LifecycleExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecycleExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecyclePolicyDetailActionType.
    /// </summary>
    public class LifecyclePolicyDetailActionType : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for LifecyclePolicyDetailActionType
        /// </summary>
        public static readonly LifecyclePolicyDetailActionType DELETE = new LifecyclePolicyDetailActionType("DELETE");
        /// <summary>
        /// Constant DEPRECATE for LifecyclePolicyDetailActionType
        /// </summary>
        public static readonly LifecyclePolicyDetailActionType DEPRECATE = new LifecyclePolicyDetailActionType("DEPRECATE");
        /// <summary>
        /// Constant DISABLE for LifecyclePolicyDetailActionType
        /// </summary>
        public static readonly LifecyclePolicyDetailActionType DISABLE = new LifecyclePolicyDetailActionType("DISABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecyclePolicyDetailActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecyclePolicyDetailActionType FindValue(string value)
        {
            return FindValue<LifecyclePolicyDetailActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecyclePolicyDetailActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecyclePolicyDetailFilterType.
    /// </summary>
    public class LifecyclePolicyDetailFilterType : ConstantClass
    {

        /// <summary>
        /// Constant AGE for LifecyclePolicyDetailFilterType
        /// </summary>
        public static readonly LifecyclePolicyDetailFilterType AGE = new LifecyclePolicyDetailFilterType("AGE");
        /// <summary>
        /// Constant COUNT for LifecyclePolicyDetailFilterType
        /// </summary>
        public static readonly LifecyclePolicyDetailFilterType COUNT = new LifecyclePolicyDetailFilterType("COUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecyclePolicyDetailFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecyclePolicyDetailFilterType FindValue(string value)
        {
            return FindValue<LifecyclePolicyDetailFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecyclePolicyDetailFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecyclePolicyResourceType.
    /// </summary>
    public class LifecyclePolicyResourceType : ConstantClass
    {

        /// <summary>
        /// Constant AMI_IMAGE for LifecyclePolicyResourceType
        /// </summary>
        public static readonly LifecyclePolicyResourceType AMI_IMAGE = new LifecyclePolicyResourceType("AMI_IMAGE");
        /// <summary>
        /// Constant CONTAINER_IMAGE for LifecyclePolicyResourceType
        /// </summary>
        public static readonly LifecyclePolicyResourceType CONTAINER_IMAGE = new LifecyclePolicyResourceType("CONTAINER_IMAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecyclePolicyResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecyclePolicyResourceType FindValue(string value)
        {
            return FindValue<LifecyclePolicyResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecyclePolicyResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecyclePolicyStatus.
    /// </summary>
    public class LifecyclePolicyStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for LifecyclePolicyStatus
        /// </summary>
        public static readonly LifecyclePolicyStatus DISABLED = new LifecyclePolicyStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for LifecyclePolicyStatus
        /// </summary>
        public static readonly LifecyclePolicyStatus ENABLED = new LifecyclePolicyStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecyclePolicyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecyclePolicyStatus FindValue(string value)
        {
            return FindValue<LifecyclePolicyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecyclePolicyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecyclePolicyTimeUnit.
    /// </summary>
    public class LifecyclePolicyTimeUnit : ConstantClass
    {

        /// <summary>
        /// Constant DAYS for LifecyclePolicyTimeUnit
        /// </summary>
        public static readonly LifecyclePolicyTimeUnit DAYS = new LifecyclePolicyTimeUnit("DAYS");
        /// <summary>
        /// Constant MONTHS for LifecyclePolicyTimeUnit
        /// </summary>
        public static readonly LifecyclePolicyTimeUnit MONTHS = new LifecyclePolicyTimeUnit("MONTHS");
        /// <summary>
        /// Constant WEEKS for LifecyclePolicyTimeUnit
        /// </summary>
        public static readonly LifecyclePolicyTimeUnit WEEKS = new LifecyclePolicyTimeUnit("WEEKS");
        /// <summary>
        /// Constant YEARS for LifecyclePolicyTimeUnit
        /// </summary>
        public static readonly LifecyclePolicyTimeUnit YEARS = new LifecyclePolicyTimeUnit("YEARS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecyclePolicyTimeUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecyclePolicyTimeUnit FindValue(string value)
        {
            return FindValue<LifecyclePolicyTimeUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecyclePolicyTimeUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MarketplaceResourceType.
    /// </summary>
    public class MarketplaceResourceType : ConstantClass
    {

        /// <summary>
        /// Constant COMPONENT_ARTIFACT for MarketplaceResourceType
        /// </summary>
        public static readonly MarketplaceResourceType COMPONENT_ARTIFACT = new MarketplaceResourceType("COMPONENT_ARTIFACT");
        /// <summary>
        /// Constant COMPONENT_DATA for MarketplaceResourceType
        /// </summary>
        public static readonly MarketplaceResourceType COMPONENT_DATA = new MarketplaceResourceType("COMPONENT_DATA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MarketplaceResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MarketplaceResourceType FindValue(string value)
        {
            return FindValue<MarketplaceResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MarketplaceResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OnWorkflowFailure.
    /// </summary>
    public class OnWorkflowFailure : ConstantClass
    {

        /// <summary>
        /// Constant ABORT for OnWorkflowFailure
        /// </summary>
        public static readonly OnWorkflowFailure ABORT = new OnWorkflowFailure("ABORT");
        /// <summary>
        /// Constant CONTINUE for OnWorkflowFailure
        /// </summary>
        public static readonly OnWorkflowFailure CONTINUE = new OnWorkflowFailure("CONTINUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnWorkflowFailure(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnWorkflowFailure FindValue(string value)
        {
            return FindValue<OnWorkflowFailure>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnWorkflowFailure(string value)
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
        /// Constant AWSMarketplace for Ownership
        /// </summary>
        public static readonly Ownership AWSMarketplace = new Ownership("AWSMarketplace");
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
        /// Constant MacOS for Platform
        /// </summary>
        public static readonly Platform MacOS = new Platform("macOS");
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


    /// <summary>
    /// Constants used for properties of type ProductCodeType.
    /// </summary>
    public class ProductCodeType : ConstantClass
    {

        /// <summary>
        /// Constant Marketplace for ProductCodeType
        /// </summary>
        public static readonly ProductCodeType Marketplace = new ProductCodeType("marketplace");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProductCodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductCodeType FindValue(string value)
        {
            return FindValue<ProductCodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductCodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceStatus.
    /// </summary>
    public class ResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus AVAILABLE = new ResourceStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus DELETED = new ResourceStatus("DELETED");
        /// <summary>
        /// Constant DEPRECATED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus DEPRECATED = new ResourceStatus("DEPRECATED");
        /// <summary>
        /// Constant DISABLED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus DISABLED = new ResourceStatus("DISABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceStatus FindValue(string value)
        {
            return FindValue<ResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SsmParameterDataType.
    /// </summary>
    public class SsmParameterDataType : ConstantClass
    {

        /// <summary>
        /// Constant AwsEc2Image for SsmParameterDataType
        /// </summary>
        public static readonly SsmParameterDataType AwsEc2Image = new SsmParameterDataType("aws:ec2:image");
        /// <summary>
        /// Constant Text for SsmParameterDataType
        /// </summary>
        public static readonly SsmParameterDataType Text = new SsmParameterDataType("text");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SsmParameterDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SsmParameterDataType FindValue(string value)
        {
            return FindValue<SsmParameterDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SsmParameterDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TenancyType.
    /// </summary>
    public class TenancyType : ConstantClass
    {

        /// <summary>
        /// Constant Dedicated for TenancyType
        /// </summary>
        public static readonly TenancyType Dedicated = new TenancyType("dedicated");
        /// <summary>
        /// Constant Default for TenancyType
        /// </summary>
        public static readonly TenancyType Default = new TenancyType("default");
        /// <summary>
        /// Constant Host for TenancyType
        /// </summary>
        public static readonly TenancyType Host = new TenancyType("host");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TenancyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TenancyType FindValue(string value)
        {
            return FindValue<TenancyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TenancyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowExecutionStatus.
    /// </summary>
    public class WorkflowExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for WorkflowExecutionStatus
        /// </summary>
        public static readonly WorkflowExecutionStatus CANCELLED = new WorkflowExecutionStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for WorkflowExecutionStatus
        /// </summary>
        public static readonly WorkflowExecutionStatus COMPLETED = new WorkflowExecutionStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for WorkflowExecutionStatus
        /// </summary>
        public static readonly WorkflowExecutionStatus FAILED = new WorkflowExecutionStatus("FAILED");
        /// <summary>
        /// Constant PENDING for WorkflowExecutionStatus
        /// </summary>
        public static readonly WorkflowExecutionStatus PENDING = new WorkflowExecutionStatus("PENDING");
        /// <summary>
        /// Constant ROLLBACK_COMPLETED for WorkflowExecutionStatus
        /// </summary>
        public static readonly WorkflowExecutionStatus ROLLBACK_COMPLETED = new WorkflowExecutionStatus("ROLLBACK_COMPLETED");
        /// <summary>
        /// Constant ROLLBACK_IN_PROGRESS for WorkflowExecutionStatus
        /// </summary>
        public static readonly WorkflowExecutionStatus ROLLBACK_IN_PROGRESS = new WorkflowExecutionStatus("ROLLBACK_IN_PROGRESS");
        /// <summary>
        /// Constant RUNNING for WorkflowExecutionStatus
        /// </summary>
        public static readonly WorkflowExecutionStatus RUNNING = new WorkflowExecutionStatus("RUNNING");
        /// <summary>
        /// Constant SKIPPED for WorkflowExecutionStatus
        /// </summary>
        public static readonly WorkflowExecutionStatus SKIPPED = new WorkflowExecutionStatus("SKIPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowExecutionStatus FindValue(string value)
        {
            return FindValue<WorkflowExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowStatus.
    /// </summary>
    public class WorkflowStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEPRECATED for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus DEPRECATED = new WorkflowStatus("DEPRECATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowStatus FindValue(string value)
        {
            return FindValue<WorkflowStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowStepActionType.
    /// </summary>
    public class WorkflowStepActionType : ConstantClass
    {

        /// <summary>
        /// Constant RESUME for WorkflowStepActionType
        /// </summary>
        public static readonly WorkflowStepActionType RESUME = new WorkflowStepActionType("RESUME");
        /// <summary>
        /// Constant STOP for WorkflowStepActionType
        /// </summary>
        public static readonly WorkflowStepActionType STOP = new WorkflowStepActionType("STOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowStepActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowStepActionType FindValue(string value)
        {
            return FindValue<WorkflowStepActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowStepActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowStepExecutionRollbackStatus.
    /// </summary>
    public class WorkflowStepExecutionRollbackStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for WorkflowStepExecutionRollbackStatus
        /// </summary>
        public static readonly WorkflowStepExecutionRollbackStatus COMPLETED = new WorkflowStepExecutionRollbackStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for WorkflowStepExecutionRollbackStatus
        /// </summary>
        public static readonly WorkflowStepExecutionRollbackStatus FAILED = new WorkflowStepExecutionRollbackStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for WorkflowStepExecutionRollbackStatus
        /// </summary>
        public static readonly WorkflowStepExecutionRollbackStatus RUNNING = new WorkflowStepExecutionRollbackStatus("RUNNING");
        /// <summary>
        /// Constant SKIPPED for WorkflowStepExecutionRollbackStatus
        /// </summary>
        public static readonly WorkflowStepExecutionRollbackStatus SKIPPED = new WorkflowStepExecutionRollbackStatus("SKIPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowStepExecutionRollbackStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowStepExecutionRollbackStatus FindValue(string value)
        {
            return FindValue<WorkflowStepExecutionRollbackStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowStepExecutionRollbackStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowStepExecutionStatus.
    /// </summary>
    public class WorkflowStepExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for WorkflowStepExecutionStatus
        /// </summary>
        public static readonly WorkflowStepExecutionStatus CANCELLED = new WorkflowStepExecutionStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for WorkflowStepExecutionStatus
        /// </summary>
        public static readonly WorkflowStepExecutionStatus COMPLETED = new WorkflowStepExecutionStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for WorkflowStepExecutionStatus
        /// </summary>
        public static readonly WorkflowStepExecutionStatus FAILED = new WorkflowStepExecutionStatus("FAILED");
        /// <summary>
        /// Constant PENDING for WorkflowStepExecutionStatus
        /// </summary>
        public static readonly WorkflowStepExecutionStatus PENDING = new WorkflowStepExecutionStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for WorkflowStepExecutionStatus
        /// </summary>
        public static readonly WorkflowStepExecutionStatus RUNNING = new WorkflowStepExecutionStatus("RUNNING");
        /// <summary>
        /// Constant SKIPPED for WorkflowStepExecutionStatus
        /// </summary>
        public static readonly WorkflowStepExecutionStatus SKIPPED = new WorkflowStepExecutionStatus("SKIPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowStepExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowStepExecutionStatus FindValue(string value)
        {
            return FindValue<WorkflowStepExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowStepExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowType.
    /// </summary>
    public class WorkflowType : ConstantClass
    {

        /// <summary>
        /// Constant BUILD for WorkflowType
        /// </summary>
        public static readonly WorkflowType BUILD = new WorkflowType("BUILD");
        /// <summary>
        /// Constant DISTRIBUTION for WorkflowType
        /// </summary>
        public static readonly WorkflowType DISTRIBUTION = new WorkflowType("DISTRIBUTION");
        /// <summary>
        /// Constant TEST for WorkflowType
        /// </summary>
        public static readonly WorkflowType TEST = new WorkflowType("TEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowType FindValue(string value)
        {
            return FindValue<WorkflowType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowType(string value)
        {
            return FindValue(value);
        }
    }

}