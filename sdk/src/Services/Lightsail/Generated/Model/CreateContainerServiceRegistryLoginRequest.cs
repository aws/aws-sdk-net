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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateContainerServiceRegistryLogin operation.
    /// Creates a temporary set of log in credentials that you can use to log in to the Docker
    /// process on your local machine. After you're logged in, you can use the native Docker
    /// commands to push your local container images to the container image registry of your
    /// Amazon Lightsail account so that you can use them with your Lightsail container service.
    /// The log in credentials expire 12 hours after they are created, at which point you
    /// will need to create a new set of log in credentials.
    /// 
    ///  <note> 
    /// <para>
    /// You can only push container images to the container service registry of your Lightsail
    /// account. You cannot pull container images or perform any other container image management
    /// actions on the container service registry.
    /// </para>
    ///  </note> 
    /// <para>
    /// After you push your container images to the container image registry of your Lightsail
    /// account, use the <c>RegisterContainerImage</c> action to register the pushed images
    /// to a specific Lightsail container service.
    /// </para>
    ///  <note> 
    /// <para>
    /// This action is not required if you install and use the Lightsail Control (lightsailctl)
    /// plugin to push container images to your Lightsail container service. For more information,
    /// see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-pushing-container-images">Pushing
    /// and managing container images on your Amazon Lightsail container services</a> in the
    /// <i>Amazon Lightsail Developer Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateContainerServiceRegistryLoginRequest : AmazonLightsailRequest
    {

    }
}