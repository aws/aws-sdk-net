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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains settings for Image Builder image resource and container image scans.
    /// </summary>
    public partial class ImageScanningConfiguration
    {
        /// <summary>
        /// Gets and sets the property EcrConfiguration. 
        /// <para>
        /// Contains Amazon ECR settings for vulnerability scans.
        /// </para>
        /// </summary>
        public EcrConfiguration EcrConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EcrConfiguration property is set.
        /// </summary>
        internal bool IsSetEcrConfiguration() => this.EcrConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImageScanningEnabled. 
        /// <para>
        /// Specifies whether Amazon Inspector scans for vulnerabilities when you create a new
        /// image. You must also enable image tests. For AMI output, <c>imageScanningTypes</c>
        /// sets whether Amazon Inspector scans the test instance or the output AMI. For container
        /// output, Amazon Inspector scans the container image that Image Builder pushes to the
        /// Amazon ECR repository from your <c>ecrConfiguration</c> settings.
        /// </para>
        ///  
        /// <para>
        /// To use container image scans, you must activate Amazon Inspector for Amazon ECR scanning
        /// in your account. The Image Builder <c>ListImageScanFindings</c> operation returns
        /// the findings of these scans.
        /// </para>
        /// </summary>
        public bool? ImageScanningEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ImageScanningEnabled property is set.
        /// </summary>
        internal bool IsSetImageScanningEnabled() => this.ImageScanningEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ImageScanningTypes. 
        /// <para>
        /// The type of vulnerability scan that Image Builder runs for AMI output when <c>imageScanningEnabled</c>
        /// is <c>true</c>. Specify a single value. If you omit <c>imageScanningTypes</c>, Image
        /// Builder uses <c>TEST_INSTANCE_CVE</c>. The scan types work as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With <c>TEST_INSTANCE_CVE</c>, Amazon Inspector scans the test instance during image
        /// tests. To use this scan, you must activate Amazon Inspector for Amazon EC2 scanning
        /// in your account. The Image Builder <c>ListImageScanFindings</c> operation returns
        /// the findings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With <c>ON_DEMAND_AMI_CVE</c>, Amazon Inspector starts an on-demand scan of the output
        /// AMI during image tests. To use this scan, you must build from an image recipe, but
        /// you do not need to activate Amazon Inspector in your account. The Amazon EC2 <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetImageFindings.html">GetImageFindings</a>
        /// operation returns the findings.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> ImageScanningTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImageScanningTypes property is set.
        /// </summary>
        internal bool IsSetImageScanningTypes() => this.ImageScanningTypes != null && (this.ImageScanningTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScanResultCondition. 
        /// <para>
        /// The condition that the output AMI's scan results must meet for the image to pass.
        /// You can set <c>scanResultCondition</c> only when <c>imageScanningTypes</c> is <c>ON_DEMAND_AMI_CVE</c>.
        /// If you omit it, Image Builder starts the scan but does not wait for it or use its
        /// results to pass or fail the image.
        /// </para>
        ///  
        /// <para>
        /// When you set <c>scanResultCondition</c>, the test phase waits for the scan to finish.
        /// Then Image Builder checks the findings against the condition. By default, Image Builder
        /// counts only findings that have a fix available. To count every finding, set <c>fixAvailable</c>
        /// to <c>false</c>. If a counted finding exceeds <c>maximumSeverityLabel</c>, Image Builder
        /// fails the image in the test phase and does not distribute the AMI.
        /// </para>
        /// </summary>
        public ScanResultCondition ScanResultCondition { get; set; }

        /// <summary>
        /// Checks to see if the ScanResultCondition property is set.
        /// </summary>
        internal bool IsSetScanResultCondition() => this.ScanResultCondition != null;
    }
}
