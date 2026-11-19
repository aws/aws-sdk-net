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
    /// The perClip trigger, which runs the function each time an event clipping output reports
    /// events. Events that the output reports together share one run, and media.clip.events
    /// contains all of them. To choose this trigger, set perClip to an empty object. 
    /// 
    ///  
    /// <para>
    /// Specify clippingSettings to name the event clipping output that reports the events.
    /// You can't use this trigger with a function that references media.transcript or media.contextual.
    /// 
    /// </para>
    /// </summary>
    public partial class ClipTrigger
    {
    }
}
