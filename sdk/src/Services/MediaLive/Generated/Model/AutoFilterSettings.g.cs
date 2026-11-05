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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// System-managed filter selection. Resolves to the perceptual filter at strength 1 where
    /// the codec is eligible (AV1 and H.265 unconditionally; H.264 only at enhanced_quality),
    /// and to no filter otherwise. An empty / undefined filter_settings_choice is treated
    /// as "auto". Carries no body (extends EmptySettings, which sets additionalProperties:
    /// false), mirroring the ColorSpacePassthroughSettings empty-settings pattern.
    /// </summary>
    public partial class AutoFilterSettings
    {
    }
}
