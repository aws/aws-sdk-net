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
    /// The defining characteristics of a specific version of an Image Builder image.
    /// </summary>
    public partial class ImageVersion
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a specific version of an Image Builder image.
        /// </para>
        ///  <note> 
        /// <para>
        /// Semantic versioning is included in each object's Amazon Resource Name (ARN), at the
        /// level that applies to that object as follows:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Versionless ARNs and Name ARNs do not include specific values in any of the nodes.
        /// The nodes are either left off entirely, or they are specified as wildcards, for example:
        /// x.x.x.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Version ARNs have only the first three nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Build version ARNs have all four nodes, and point to a specific build for a specific
        /// version of an object.
        /// </para>
        ///  </li> </ol> </note>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BuildType. 
        /// <para>
        /// Indicates the type of build that created this image. The build can be initiated in
        /// the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>USER_INITIATED</b> – A manual pipeline build request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SCHEDULED</b> – A pipeline build initiated by a cron expression in the Image Builder
        /// pipeline, or from EventBridge.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IMPORT</b> – A VM import created the image to use as the base image for the recipe.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IMPORT_ISO</b> – An ISO disk import created the image.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BuildType BuildType { get; set; }

        /// <summary>
        /// Checks to see if the BuildType property is set.
        /// </summary>
        internal bool IsSetBuildType() => this.BuildType != null;

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date on which this specific version of the Image Builder image was created.
        /// </para>
        /// </summary>
        public string DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated != null;

        /// <summary>
        /// Gets and sets the property ImageSource. 
        /// <para>
        /// The origin of the base image that Image Builder used to build this image.
        /// </para>
        /// </summary>
        public ImageSource ImageSource { get; set; }

        /// <summary>
        /// Checks to see if the ImageSource property is set.
        /// </summary>
        internal bool IsSetImageSource() => this.ImageSource != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this specific version of an Image Builder image.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OsVersion. 
        /// <para>
        /// The operating system version of the image. For example, Amazon Linux 2023 or Microsoft
        /// Windows Server 2022.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Checks to see if the OsVersion property is set.
        /// </summary>
        internal bool IsSetOsVersion() => this.OsVersion != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the image version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system platform of the image version, for example "Windows" or "Linux".
        /// </para>
        /// </summary>
        public Platform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies whether this image produces an AMI or a container image.
        /// </para>
        /// </summary>
        public ImageType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The semantic version of the image. This version follows the semantic version syntax.
        /// </para>
        ///  <note> 
        /// <para>
        /// The semantic version has four nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;/&lt;build&gt;.
        /// You can assign values for the first three, and can filter on all of them.
        /// </para>
        ///  
        /// <para>
        ///  <b>Assignment:</b> For the first three nodes, you can assign any positive integer
        /// value, including zero. The upper limit is 2^30-1, or 1073741823, for each node. Image
        /// Builder automatically assigns the build number to the fourth node.
        /// </para>
        ///  
        /// <para>
        ///  <b>Patterns:</b> You can use any numeric pattern that adheres to the assignment requirements
        /// for the nodes that you can assign. For example, you might choose a software version
        /// pattern, such as 1.0.0, or a date, such as 2021.01.01.
        /// </para>
        ///  
        /// <para>
        ///  <b>Filtering:</b> You can use wildcards (x) to specify the most recent versions or
        /// nodes when selecting the base image or components for your recipe. When you use a
        /// wildcard in any node, all nodes to the right of the first wildcard must also be wildcards.
        /// </para>
        ///  </note>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
