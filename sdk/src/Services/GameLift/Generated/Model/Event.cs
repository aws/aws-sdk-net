/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Log entry describing an event that involves Amazon GameLift resources (such as a fleet).
    /// In addition to tracking activity, event codes and messages can provide additional
    /// information for troubleshooting and debugging problems.
    /// </summary>
    public partial class Event
    {
        private EventCode _eventCode;
        private string _eventId;
        private DateTime? _eventTime;
        private string _message;
        private string _preSignedLogUrl;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property EventCode. 
        /// <para>
        /// Type of event being logged. The following events are currently in use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>GENERIC_EVENT</b> – An unspecified event has occurred.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Fleet creation events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>FLEET_CREATED</b> – A fleet record was successfully created with a status of <code>NEW</code>.
        /// Event messaging includes the fleet ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_STATE_DOWNLOADING</b> – Fleet status changed from <code>NEW</code> to <code>DOWNLOADING</code>.
        /// The compressed build has started downloading to a fleet instance for installation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_BINARY_DOWNLOAD_FAILED</b> – The build failed to download to the fleet instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_CREATION_EXTRACTING_BUILD</b> – The game server build was successfully downloaded
        /// to an instance, and the build files are now being extracted from the uploaded build
        /// and saved to an instance. Failure at this stage prevents a fleet from moving to <code>ACTIVE</code>
        /// status. Logs for this stage display a list of the files that are extracted and saved
        /// on the instance. Access the logs by using the URL in <i>PreSignedLogUrl</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_CREATION_RUNNING_INSTALLER</b> – The game server build files were successfully
        /// extracted, and the Amazon GameLift is now running the build's install script (if one
        /// is included). Failure in this stage prevents a fleet from moving to <code>ACTIVE</code>
        /// status. Logs for this stage list the installation steps and whether or not the install
        /// completed successfully. Access the logs by using the URL in <i>PreSignedLogUrl</i>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_CREATION_VALIDATING_RUNTIME_CONFIG</b> – The build process was successful,
        /// and the Amazon GameLift is now verifying that the game server launch paths, which
        /// are specified in the fleet's run-time configuration, exist. If any listed launch path
        /// exists, Amazon GameLift tries to launch a game server process and waits for the process
        /// to report ready. Failures in this stage prevent a fleet from moving to <code>ACTIVE</code>
        /// status. Logs for this stage list the launch paths in the run-time configuration and
        /// indicate whether each is found. Access the logs by using the URL in <i>PreSignedLogUrl</i>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_STATE_VALIDATING</b> – Fleet status changed from <code>DOWNLOADING</code>
        /// to <code>VALIDATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_VALIDATION_LAUNCH_PATH_NOT_FOUND</b> – Validation of the run-time configuration
        /// failed because the executable specified in a launch path does not exist on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_STATE_BUILDING</b> – Fleet status changed from <code>VALIDATING</code> to
        /// <code>BUILDING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_VALIDATION_EXECUTABLE_RUNTIME_FAILURE</b> – Validation of the run-time configuration
        /// failed because the executable specified in a launch path failed to run on the fleet
        /// instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_STATE_ACTIVATING</b> – Fleet status changed from <code>BUILDING</code> to
        /// <code>ACTIVATING</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_ACTIVATION_FAILED</b> - The fleet failed to successfully complete one of
        /// the steps in the fleet activation process. This event code indicates that the game
        /// build was successfully downloaded to a fleet instance, built, and validated, but was
        /// not able to start a server process. A possible reason for failure is that the game
        /// server is not reporting "process ready" to the Amazon GameLift service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_STATE_ACTIVE</b> – The fleet's status changed from <code>ACTIVATING</code>
        /// to <code>ACTIVE</code>. The fleet is now ready to host game sessions.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Other fleet events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>FLEET_SCALING_EVENT</b> – A change was made to the fleet's capacity settings (desired
        /// instances, minimum/maximum scaling limits). Event messaging includes the new capacity
        /// settings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_NEW_GAME_SESSION_PROTECTION_POLICY_UPDATED</b> – A change was made to the
        /// fleet's game session protection policy setting. Event messaging includes both the
        /// old and new policy setting. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FLEET_DELETED</b> – A request to delete a fleet was initiated.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public EventCode EventCode
        {
            get { return this._eventCode; }
            set { this._eventCode = value; }
        }

        // Check to see if EventCode property is set
        internal bool IsSetEventCode()
        {
            return this._eventCode != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// Unique identifier for a fleet event.
        /// </para>
        /// </summary>
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// Time stamp indicating when this event occurred. Format is a number expressed in Unix
        /// time as milliseconds (for example "1469498468.057").
        /// </para>
        /// </summary>
        public DateTime EventTime
        {
            get { return this._eventTime.GetValueOrDefault(); }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Additional information related to the event.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property PreSignedLogUrl. 
        /// <para>
        /// Location of stored logs with additional detail that is related to the event. This
        /// is useful for debugging issues. The URL is valid for 15 minutes. You can also access
        /// fleet creation logs through the Amazon GameLift console.
        /// </para>
        /// </summary>
        public string PreSignedLogUrl
        {
            get { return this._preSignedLogUrl; }
            set { this._preSignedLogUrl = value; }
        }

        // Check to see if PreSignedLogUrl property is set
        internal bool IsSetPreSignedLogUrl()
        {
            return this._preSignedLogUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Unique identifier for an event resource, such as a fleet ID.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}