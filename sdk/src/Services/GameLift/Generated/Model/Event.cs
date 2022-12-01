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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Log entry describing an event that involves GameLift resources (such as a fleet).
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
        /// The type of event being logged. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Fleet state transition events:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// FLEET_CREATED -- A fleet resource was successfully created with a status of <code>NEW</code>.
        /// Event messaging includes the fleet ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_STATE_DOWNLOADING -- Fleet status changed from <code>NEW</code> to <code>DOWNLOADING</code>.
        /// The compressed build has started downloading to a fleet instance for installation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_STATE_VALIDATING -- Fleet status changed from <code>DOWNLOADING</code> to <code>VALIDATING</code>.
        /// GameLift has successfully downloaded the build and is now validating the build files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_STATE_BUILDING -- Fleet status changed from <code>VALIDATING</code> to <code>BUILDING</code>.
        /// GameLift has successfully verified the build files and is now running the installation
        /// scripts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_STATE_ACTIVATING -- Fleet status changed from <code>BUILDING</code> to <code>ACTIVATING</code>.
        /// GameLift is trying to launch an instance and test the connectivity between the build
        /// and the GameLift Service via the Server SDK.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_STATE_ACTIVE -- The fleet's status changed from <code>ACTIVATING</code> to <code>ACTIVE</code>.
        /// The fleet is now ready to host game sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_STATE_ERROR -- The Fleet's status changed to <code>ERROR</code>. Describe the
        /// fleet event message for more details.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Fleet creation events (ordered by fleet creation activity):</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// FLEET_BINARY_DOWNLOAD_FAILED -- The build failed to download to the fleet instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_CREATION_EXTRACTING_BUILD -- The game server build was successfully downloaded
        /// to an instance, and the build files are now being extracted from the uploaded build
        /// and saved to an instance. Failure at this stage prevents a fleet from moving to ACTIVE
        /// status. Logs for this stage display a list of the files that are extracted and saved
        /// on the instance. Access the logs by using the URL in <i>PreSignedLogUrl</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_CREATION_RUNNING_INSTALLER -- The game server build files were successfully
        /// extracted, and the GameLift is now running the build's install script (if one is included).
        /// Failure in this stage prevents a fleet from moving to ACTIVE status. Logs for this
        /// stage list the installation steps and whether or not the install completed successfully.
        /// Access the logs by using the URL in <i>PreSignedLogUrl</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_CREATION_VALIDATING_RUNTIME_CONFIG -- The build process was successful, and
        /// the GameLift is now verifying that the game server launch paths, which are specified
        /// in the fleet's runtime configuration, exist. If any listed launch path exists, GameLift
        /// tries to launch a game server process and waits for the process to report ready. Failures
        /// in this stage prevent a fleet from moving to <code>ACTIVE</code> status. Logs for
        /// this stage list the launch paths in the runtime configuration and indicate whether
        /// each is found. Access the logs by using the URL in <i>PreSignedLogUrl</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_VALIDATION_LAUNCH_PATH_NOT_FOUND -- Validation of the runtime configuration
        /// failed because the executable specified in a launch path does not exist on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_VALIDATION_EXECUTABLE_RUNTIME_FAILURE -- Validation of the runtime configuration
        /// failed because the executable specified in a launch path failed to run on the fleet
        /// instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_VALIDATION_TIMED_OUT -- Validation of the fleet at the end of creation timed
        /// out. Try fleet creation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_ACTIVATION_FAILED -- The fleet failed to successfully complete one of the steps
        /// in the fleet activation process. This event code indicates that the game build was
        /// successfully downloaded to a fleet instance, built, and validated, but was not able
        /// to start a server process. For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-debug.html#fleets-creating-debug-creation">Debug
        /// Fleet Creation Issues</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_ACTIVATION_FAILED_NO_INSTANCES -- Fleet creation was not able to obtain any
        /// instances based on the input fleet attributes. Try again at a different time or choose
        /// a different combination of fleet attributes such as fleet type, instance type, etc.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_INITIALIZATION_FAILED -- A generic exception occurred during fleet creation.
        /// Describe the fleet event message for more details.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>VPC peering events:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// FLEET_VPC_PEERING_SUCCEEDED -- A VPC peering connection has been established between
        /// the VPC for an GameLift fleet and a VPC in your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_VPC_PEERING_FAILED -- A requested VPC peering connection has failed. Event details
        /// and status information provide additional detail. A common reason for peering failure
        /// is that the two VPCs have overlapping CIDR blocks of IPv4 addresses. To resolve this,
        /// change the CIDR block for the VPC in your Amazon Web Services account. For more information
        /// on VPC peering failures, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/PeeringGuide/invalid-peering-configurations.html">https://docs.aws.amazon.com/AmazonVPC/latest/PeeringGuide/invalid-peering-configurations.html</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_VPC_PEERING_DELETED -- A VPC peering connection has been successfully deleted.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Spot instance events:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  INSTANCE_INTERRUPTED -- A spot instance was interrupted by EC2 with a two-minute
        /// notification.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Server process events:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SERVER_PROCESS_INVALID_PATH -- The game server executable or script could not be found
        /// based on the Fleet runtime configuration. Check that the launch path is correct based
        /// on the operating system of the Fleet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVER_PROCESS_SDK_INITIALIZATION_TIMEOUT -- The server process did not call InitSDK()
        /// within the time expected. Check your game session log to see why InitSDK() was not
        /// called in time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVER_PROCESS_PROCESS_READY_TIMEOUT -- The server process did not call ProcessReady()
        /// within the time expected after calling InitSDK(). Check your game session log to see
        /// why ProcessReady() was not called in time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVER_PROCESS_CRASHED -- The server process exited without calling ProcessEnding().
        /// Check your game session log to see why ProcessEnding() was not called.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVER_PROCESS_TERMINATED_UNHEALTHY -- The server process did not report a valid health
        /// check for too long and was therefore terminated by GameLift. Check your game session
        /// log to see if the thread became stuck processing a synchronous task for too long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVER_PROCESS_FORCE_TERMINATED -- The server process did not exit cleanly after OnProcessTerminate()
        /// was sent within the time expected. Check your game session log to see why termination
        /// took longer than expected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVER_PROCESS_PROCESS_EXIT_TIMEOUT -- The server process did not exit cleanly within
        /// the time expected after calling ProcessEnding(). Check your game session log to see
        /// why termination took longer than expected.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Game session events:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// GAME_SESSION_ACTIVATION_TIMEOUT -- GameSession failed to activate within the expected
        /// time. Check your game session log to see why ActivateGameSession() took longer to
        /// complete than expected.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Other fleet events:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// FLEET_SCALING_EVENT -- A change was made to the fleet's capacity settings (desired
        /// instances, minimum/maximum scaling limits). Event messaging includes the new capacity
        /// settings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_NEW_GAME_SESSION_PROTECTION_POLICY_UPDATED -- A change was made to the fleet's
        /// game session protection policy setting. Event messaging includes both the old and
        /// new policy setting. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_DELETED -- A request to delete a fleet was initiated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  GENERIC_EVENT -- An unspecified event has occurred.
        /// </para>
        ///  </li> </ul>
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
        /// A unique identifier for a fleet event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// time as milliseconds (for example <code>"1469498468.057"</code>).
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
        [AWSProperty(Min=1)]
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
        /// fleet creation logs through the GameLift console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// A unique identifier for an event resource, such as a fleet ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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