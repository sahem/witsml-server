//----------------------------------------------------------------------- 
// PDS.Witsml, 2016.1
//
// Copyright 2016 Petrotechnical Data Systems
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

// ----------------------------------------------------------------------
// <auto-generated>
//     Changes to this file may cause incorrect behavior and will be lost
//     if the code is regenerated.
// </auto-generated>
// ----------------------------------------------------------------------

using Witsml131 = Energistics.DataAccess.WITSML131;
using Witsml141 = Energistics.DataAccess.WITSML141;
using Witsml200 = Energistics.DataAccess.WITSML200;

namespace PDS.Witsml.Server.Data
{
    /// <summary>
    /// Initializes MongoDb class and member mappings.
    /// </summary>
    public partial class MongoDbClassMapper
    {
        private void RegisterDataTypes()
        {
            // attachment
            Register<Witsml141.Attachment>();
            Register2<Witsml200.Attachment>();

            // channel
            Register2<Witsml200.Channel>();

            // channelSet
            Register2<Witsml200.ChannelSet>();

            // log
            Register<Witsml131.Log>();
            Register<Witsml141.Log>();
            Register2<Witsml200.Log>();

            // message
            Register<Witsml131.Message>();
            Register<Witsml141.Message>();

            // rig
            Register<Witsml131.Rig>();
            Register<Witsml141.Rig>();
            Register2<Witsml200.Rig>();

            // trajectory
            Register<Witsml131.Trajectory>();
            Register<Witsml141.Trajectory>();
            Register2<Witsml200.Trajectory>();

            // wbGeometry
            Register<Witsml131.StandAloneWellboreGeometry>();
            Register<Witsml141.StandAloneWellboreGeometry>();

            // well
            Register<Witsml131.Well>();
            Register<Witsml141.Well>();
            Register2<Witsml200.Well>();

            // wellbore
            Register<Witsml131.Wellbore>();
            Register<Witsml141.Wellbore>();
            Register2<Witsml200.Wellbore>();

        }
    }
}