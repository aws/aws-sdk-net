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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// The perScene trigger, which runs the function once for each scene that a contextual
    /// metadata output reports. The function runs after the scene ends, with the media of
    /// that scene. To choose this trigger, set perScene to an empty object. 
    /// 
    ///  
    /// <para>
    /// Specify contextualMetadataSettings to name the contextual metadata output that reports
    /// the scenes. You can't use this trigger with a function that references media.transcript
    /// or media.clip. 
    /// </para>
    /// </summary>
    public partial class SceneTrigger
    {
    }
}
