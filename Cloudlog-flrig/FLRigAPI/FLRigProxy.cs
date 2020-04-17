﻿using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudlog_flrig.FLRigAPI
{
    [XmlRpcUrl("http://127.0.0.1:12345")]
    public interface FLRigProxy : IXmlRpcProxy
    {
        //main.set_frequency  d:d  set current VFO in Hz
        //main.get_version    s:n  returns version string
        //rig.get_AB          s:n  returns vfo in use A or B
        //rig.get_bw          s:n  return BW of current VFO
        //rig.get_bws         s:n  return table of BW values
        //rig.get_bwA         s:n  return BW of vfo A
        //rig.get_bwB         s:n  return BW of vfo B

        //rig.get_info        s:n  return an info string
        [XmlRpcMethod("rig.get_info")]
        object get_info();

        //rig.get_mode        s:n  return MODE of current VFO
        [XmlRpcMethod("rig.get_mode")]
        object get_mode();

        //rig.get_modeA       s:n  return MODE of current VFO A
        //rig.get_modeB       s:n  return MODE of current VFO B
        //rig.get_modes       s:n  return table of MODE values
        //rig.get_sideband    s:n  return sideband (U/L)
        //rig.get_notch       s:n  return notch value
        //rig.get_ptt         s:n  return PTT state
        //rig.get_power       s:n  return power level control value
        //rig.get_pwrmeter    s:n  return PWR out
        //rig.get_smeter      s:n  return Smeter
        //rig.get_split       s:n  return split state
        //rig.get_update      s:n  return update to info

        //rig.get_vfo         s:n  return current VFO in Hz
        [XmlRpcMethod("rig.get_vfo")]
        object get_vfo();

        //rig.get_vfoA        s:n  return vfo A in Hz
        //rig.get_vfoB        s:n  return vfo B in Hz
        //rig.get_xcvr        s:n  returns name of transceiver
        //rig.get_volume      s:n  returns volume control value
        //rig.get_rfgain      s:n  returns rf gain control value
        //rig.get_micgain     s:n  returns mic gain control value
        //rig.set_AB          s:s  set VFO A/B
        //rig.set_bw          i:i  set BW iaw BW table
        //rig.set_bandwidth   i:i  set bandwidth to nearest requested value
        //rig.set_BW          i:i  set L/U pair
        //rig.set_frequency   d:d  set current VFO in Hz
        //rig.set_mode        i:i  set MODE iaw MODE table
        //rig.set_modeA       i:i  set MODE A iaw MODE table
        //rig.set_modeB       i:i  set MODE B iaw MODE table
        //rig.set_notch       d:d  set NOTCH value in Hz
        //rig.set_power       i:i  set power control level, watts
        //rig.set_ptt         i:i  set PTT 1/0 (on/off)
        //rig.set_vfo         d:d  set current VFO in Hz
        //rig.set_vfoA        d:d  set vfo A in Hz
        //rig.set_vfoB        d:d  set vfo B in Hz
        //rig.set_split       i:i  set split 1/0 (on/off)
        //rig.set_volume      i:i  sets volume control
        //rig.set_rfgain      i:i  sets rf gain control
        //rig.set_micgain     i:i  sets mic gain control
        //rig.swap            i:i  execute vfo swap
        //rig.cat_string      s:s  execute CAT string
        //rig.shutdown        i:i  shutdown xcvr & flrig
    }
}
